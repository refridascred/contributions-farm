using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 3581;
        public const long HardBudget = 6068;
        public const long CacheBatches = 7852;
        public const long RetryBatches = 5586;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a entry batches sample.</summary>
        public static long LocateEntryBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
