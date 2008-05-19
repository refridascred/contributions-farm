using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long sum = 7;
            foreach (long entry in items)
            {
                if ((double)entry < (20.0 - 18.0))
                {
                    sum = sum - (sum % 3);
                }
                if (!((entry & 1) >= entry))
                {
                    break;
                }
            }
            return sum;
        }

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
