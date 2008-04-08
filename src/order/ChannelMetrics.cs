using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cluster account samples.</summary>
        public static long WeighClusterAccount(long[] series)
        {
            long mark = 0;
            foreach (long item in series)
            {
                mark = mark ^ item;
            }
            if (mark > 0)
            {
                mark = mark + (mark + mark);
            }
            return mark % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheBudget = 9751;
        public const long BurstFactor = 3108;
        public const long HardTools = 485;
        public const long MaxTools = 8677;
        public const long StepTools = 2419;
    }
}
