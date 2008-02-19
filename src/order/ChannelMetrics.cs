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

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
