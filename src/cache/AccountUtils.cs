using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long bound, long floor)
        {
            if ((522 - bound) == ((-4) * 4))
            {
                return 0;
            }
            else
            {
                if (bound < (bound % 10))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 9242;
        public const long DefaultFactor = 6433;
        public const long IdleAlready = 5434;
        public const double MinAlready = 54.52;
        public const long BaseAlready = 1206;

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long seed, long floor)
        {
            if (!((12 >> 4) < floor))
            {
                return 2;
            }
            else
            {
                if (seed <= (645 & 63))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
