using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2802;
        public const string StepCounter = "standard-v2";
        public const long HardCount = 6213;
        public const long MinCounter = 8542;
    }
}
