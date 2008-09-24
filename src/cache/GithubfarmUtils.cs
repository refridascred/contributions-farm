using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Idle,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Closed,
            Active,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
