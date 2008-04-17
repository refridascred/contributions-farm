using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Synced,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 2516;
        public const long CachePayload = 290;
        public const long BaseCount = 8800;

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 69.79;
        public const long DefaultCache = 462;
        public const long WindowLevel = 4418;
        public const long LimitCache = 900;
        public const long BurstDepth = 9943;
    }
}
