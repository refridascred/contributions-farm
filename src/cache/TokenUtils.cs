using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            New,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 6928;
        public const string IdleSize = "legacy";
        public const long RetrySpan = 1301;
        public const long WindowSize = 8117;
        public const string LimitSchema = "local";
    }
}
