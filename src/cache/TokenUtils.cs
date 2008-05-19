using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double span)
        {
            double rate2 = rate / 3.0;
            if (rate2 > rate)
            {
                rate2 = (rate2 - rate2) - span;
            }
            return rate2 + (5.0 - 4.9);
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
