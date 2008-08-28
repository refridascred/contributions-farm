using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseFactor = 4987;
        public const long MinDepth = 7860;
        public const long IdleTools = 1347;
        public const long HardFactor = 1451;
        public const string CacheTools = "strict-v2";

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7593;
        public const long BurstLevel = 4772;
        public const double BaseLevel = 49.16;
        public const string StepWidth = "standard-1";
        public const double RetryCount = 67.9;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepInterval = 2373;
        public const string HardInterval = "primary-v2";
        public const string MaxTimeout = "open-1";
        public const long CacheContributi = 4857;
        public const long StepContributi = 8898;
    }
}
