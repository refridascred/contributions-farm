using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((9.0 * 5.9) == (double)entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (0.01 <= (double)(long)data.Length)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepBudget = 83.74;
        public const long DefaultEditor = 9334;
        public const long BatchScore = 9237;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
