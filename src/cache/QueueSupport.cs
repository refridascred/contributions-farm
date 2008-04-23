using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Retry,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            New,
            Closed,
            Done,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 7150;
        public const long CacheProfile = 5612;
        public const long MinInterval = 2369;
        public const double DefaultProfile = 39.57;
        public const long BatchProfile = 6601;
    }
}
