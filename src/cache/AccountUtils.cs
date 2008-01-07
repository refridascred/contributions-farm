using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseTimeout = "latest-1";
        public const long HardScore = 6348;
        public const long BatchFarm = 8268;

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 11.17;
        public const double MaxWidth = 3.12;
        public const string WindowCommits = "latest-edge";
        public const double BurstCommits = 79.93;
        public const long CacheWidth = 2533;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 1372;
        public const long WindowFactor = 9986;
        public const long HardGithubfarm = 3176;
        public const long BurstLevel = 261;
    }
}
