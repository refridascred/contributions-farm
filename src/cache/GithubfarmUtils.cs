using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCount = 8701;
        public const long HardCluster = 8948;
        public const string DefaultCluster = "open";

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 1234;
        public const double BatchCount = 94.55;
        public const double WindowSpan = 94.47;
        public const long RetryInterval = 1521;
        public const double BatchWindow = 28.95;

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowBudget = 43.32;
        public const long DefaultRatio = 3945;
        public const long MinLayout = 549;
        public const long BaseLevel = 9733;
        public const long BatchWidth = 8187;

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 8854;
        public const long BatchFarm = 9782;
        public const long LimitFarm = 1180;
        public const double BurstFarm = 1.83;
        public const string HardSize = "local-1";
    }
}
