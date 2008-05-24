using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Stale,
            Retry,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Active,
            Idle,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Paused,
            Done,
            Ready,
        }
    }
}
