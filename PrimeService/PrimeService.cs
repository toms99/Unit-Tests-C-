using System;
namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate, int i)
        {
            if (i > 1)
            {
                if (candidate % i != 0)
                {
                    return IsPrime(candidate, i - 1);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }
    }
}
