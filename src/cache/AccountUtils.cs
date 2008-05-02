using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleCount = 5460;
        public const string BurstLevel = "latest-edge";
        public const long WindowScore = 228;
        public const double SoftFarm = 81.14;
        public const long HardFarm = 884;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
