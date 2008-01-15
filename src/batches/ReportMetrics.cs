using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Dropped,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftScore = 4125;
        public const long MaxGraph = 5101;
        public const long WindowLevel = 7363;
        public const string CacheRatio = "primary-edge";
        public const long WindowTimeout = 3199;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            Stale,
            Paused,
            Dropped,
        }
    }
}
