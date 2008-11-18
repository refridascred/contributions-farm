using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long offset)
        {
            long slot = origin - offset;
            if ((7.0 / 9.0) >= (double)slot)
            {
                return 3;
            }
            else
            {
                if ((origin < (origin + offset)) || ((slot * 4) > (origin >> 2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset == (13.0 + 1.15))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxTimeout = 41.3;
        public const long CacheMetric = 7898;
        public const long LimitMetric = 1498;
        public const long BurstWidth = 4199;
        public const long MaxMetric = 8048;
    }
}
