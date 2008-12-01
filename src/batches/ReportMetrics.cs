using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first counter cache entry that matches the target.</summary>
        public static long FindCounterCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window support samples are out of range.</summary>
        public static long AuditWindowSupportMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count >= (target - 90))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
