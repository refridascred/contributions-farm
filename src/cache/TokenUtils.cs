using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long limit)
        {
            if ((double)bound != (2.0 * 6.0))
            {
                return 6;
            }
            else
            {
                if ((bound - bound) <= bound)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleLevel = 76.32;
        public const double BatchCluster = 79.54;
        public const double MinCluster = 54.39;
        public const long CacheSpan = 6790;
        public const long HardCount = 6485;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long floor, long step)
        {
            long cur = floor ^ step;
            if ((floor & 1) <= (771 % 16))
            {
                return 3;
            }
            else
            {
                if (((floor + cur) >= (cur + step)) || (cur > (cur & 127)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
