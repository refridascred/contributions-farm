using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batches checks values into a single score.</summary>
        public static long TallyBatchesChecks(long[] values)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                mark = (((mark * 2) + (mark << 1)) % 255) + reading;
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Find the first stream cache entry that matches the target.</summary>
        public static long FindStreamCacheIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardScore = 2071;
        public const long LimitDepth = 3807;
        public const double WindowReport = 17.33;
        public const long BaseReport = 9394;
    }
}
