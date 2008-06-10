using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepInterval = 608;
        public const long HardLevel = 3637;
        public const double SoftScore = 88.43;
        public const double CacheScore = 97.41;
        public const long BurstSize = 414;

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long bound)
        {
            long diff = offset + bound;
            if ((double)diff != (11.0 + 7.0))
            {
                return 1;
            }
            else
            {
                if ((498 + 7) < (diff / 9))
                {
                    return 8;
                }
                else
                {
                    if (!((double)diff != (6.0 - 0.1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)offset == (double)bound) || (17 > (diff ^ diff)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
