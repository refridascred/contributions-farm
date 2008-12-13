using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleDepth = "local";
        public const string StepDepth = "strict";
        public const string CacheMetrics = "alpha";

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Idle,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Dropped,
            Idle,
            Paused,
        }
    }
}
