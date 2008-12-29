using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Done,
            Closed,
            Failed,
            Synced,
        }
    }
}
