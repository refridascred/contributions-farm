using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Active,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 6737;
        public const long HardInterval = 1896;
        public const long BurstTimeout = 8542;
        public const double SoftBatch = 87.21;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
