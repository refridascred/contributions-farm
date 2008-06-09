using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinTimeout = 4774;
        public const long WindowBudget = 2871;
        public const long CacheChecks = 4158;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "cached-v2";
        public const string DefaultBudget = "staging";
        public const double CacheRatio = 40.54;

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 40.5;
        public const long StepCount = 4353;
        public const long BatchCount = 3605;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Stale,
            Closed,
        }
    }
}
