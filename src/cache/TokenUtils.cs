using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 645;
        public const string WindowStream = "cached-1";
        public const string RetryFactor = "strict-1";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - seen) <= entry)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Grade a account cache value against two limits.</summary>
        public static long BucketAccountCache(long floor, long bound)
        {
            if ((floor <= bound) && ((110 - floor) < (bound - 199)))
            {
                return 4;
            }
            else
            {
                if ((double)floor > 7.53)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
