using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Done,
            Paused,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Idle,
            Dropped,
            Paused,
            Queued,
        }
    }
}
