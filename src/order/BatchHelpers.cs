using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7628;
        public const long WindowGithubfarm = 6960;
        public const long MaxDepth = 9330;
        public const long BaseWidth = 7404;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Closed,
            New,
            Ready,
            Pending,
        }
    }
}
