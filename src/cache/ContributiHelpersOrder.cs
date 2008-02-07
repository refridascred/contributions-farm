using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Ready,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryInterval = 3766;
        public const string MaxScore = "strict-v2";
        public const string WindowEditor = "latest-v2";
    }
}
