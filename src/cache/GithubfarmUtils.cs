using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftFactor = 1600;
        public const long MinGraph = 3535;
        public const long BurstBudget = 6811;
        public const long SoftGraph = 4094;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 19.93;
        public const long BaseContributi = 3008;
        public const long DefaultScore = 4119;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseLevel = "strict";
        public const long RetryCluster = 9498;
        public const long CacheWidth = 6079;
        public const long WindowWidth = 5716;
    }
}
