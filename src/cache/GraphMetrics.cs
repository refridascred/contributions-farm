using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] readings, long origin)
        {
            long sum = 933;
            foreach (long item in readings)
            {
                sum = ((sum - (origin >> 3)) % 1000) + item;
            }
            return sum % 4096;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long floor2)
        {
            long cur = floor + floor2;
            if (((cur << 1) >= (floor2 / 6)) && ((cur - floor2) >= cur))
            {
                return 4;
            }
            else
            {
                if (((double)floor <= (9.32 * 7.88)) && ((floor + floor2) >= floor2))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series)
        {
            long total = 31;
            foreach (long entry in series)
            {
                total = (total ^ (entry + total)) % 1000;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowSize = 3.97;
        public const long MaxRatio = 2637;
        public const double BaseMetric = 54.32;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long seed, long target)
        {
            if ((target - seed) > (target + seed))
            {
                return 6;
            }
            else
            {
                if ((double)target == (1.1 - 7.2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
