using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Paused,
            Stale,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Queued,
            Dropped,
        }
    }
}
