using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowFactor = 9588;
        public const double BurstEditor = 16.93;
        public const string RetryBudget = "primary";

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "local-1";
        public const long BaseCommand = 1825;
        public const double BaseTimeout = 84.21;
        public const long WindowRatio = 391;
        public const long MaxBudget = 5448;
    }
}
