using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Active,
            Ready,
            Retry,
            New,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Failed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 54.03;
        public const double BatchGithubfarm = 2.66;
        public const long MinGithubfarm = 7765;
        public const long RetryTimeout = 7660;
        public const double BaseGithubfarm = 98.22;
    }
}
