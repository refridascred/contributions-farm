using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Failed,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 2412;
        public const string RetryRecord = "fallback-edge";
        public const long DefaultRecord = 5968;
        public const double StepWidth = 4.46;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Done,
            Active,
        }
    }
}
