using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Dropped,
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryLevel = 1187;
        public const double StepWidth = 26.58;
        public const long BaseFilter = 7986;
        public const string BatchFilter = "standard";

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
