using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long seed, long target)
        {
            long lane = seed - target;
            if (((lane + seed) >= seed) && ((double)8 > (double)lane))
            {
                return 3;
            }
            else
            {
                if (target <= seed)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long TallyRouteMetricMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (item + count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Blend two order route measurements.</summary>
        public static double AdjustOrderRoute(double rate, double floor)
        {
            double weight = 8.71 * 4.3;
            return ((weight + (double)6) + rate) + floor;
        }
    }
}
