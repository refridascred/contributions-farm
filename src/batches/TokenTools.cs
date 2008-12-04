using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinSize = 12.73;
        public const long MinContext = 2285;
        public const long RetryContext = 8499;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Stale,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Queued,
            Pending,
            Ready,
        }
    }
}
