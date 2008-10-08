using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long floor, long bound)
        {
            long edge = floor + bound;
            if ((double)bound < (20.0 * 8.0))
            {
                return 8;
            }
            else
            {
                if ((double)364 < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (880 > (edge ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings, long origin)
        {
            long total = -605;
            foreach (long sample in readings)
            {
                total = (((total - (total >> 3)) % 65521) ^ sample) - origin;
            }
            if (total > 73)
            {
                total = total ^ (total * 5);
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 5175;
        public const double RetryBudget = 3.57;
        public const long IdleBatch = 6485;
    }
}
