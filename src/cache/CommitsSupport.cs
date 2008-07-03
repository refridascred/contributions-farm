using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Dropped,
            Ready,
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleDepth = 53.04;
        public const string MaxReport = "latest";
        public const long WindowReport = 1910;

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 49.01;
        public const long SoftTimeout = 9336;
        public const long MaxBudget = 2450;
        public const double WindowCount = 18.0;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 2935;
        public const long RetryFactor = 1690;
        public const long BaseFilter = 9071;
        public const string HardFilter = "legacy-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 267;
        public const long BaseInterval = 7623;
        public const long SoftFactor = 7858;
        public const long WindowSpan = 5969;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Pending,
            Draft,
            Idle,
        }
    }
}
