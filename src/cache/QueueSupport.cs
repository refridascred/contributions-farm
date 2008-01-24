using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Ready,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 20.08;
        public const long RetryGithubfarm = 7679;
        public const long SoftGithubfarm = 6369;
        public const long BatchSpan = 2443;
        public const long RetryWidth = 3304;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Closed,
            Synced,
            Active,
        }
    }
}
