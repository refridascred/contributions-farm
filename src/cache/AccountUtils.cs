using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Level { get; set; } = "";
        }

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
