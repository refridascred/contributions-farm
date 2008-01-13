using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metrics queue entries that pass the check.</summary>
        public static long AuditMetricsQueueHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((floor + seen) != (floor - seen))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Done,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "alpha";
        public const long SoftDepth = 6025;
        public const long CacheQueue = 4724;
        public const string BurstSpan = "legacy-1";

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Mode { get; set; }
        }
    }
}
