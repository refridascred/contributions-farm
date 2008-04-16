using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "cached-v2";
        public const string StepWidth = "stable";
        public const double LimitBatches = 7.64;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
