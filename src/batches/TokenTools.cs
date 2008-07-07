using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            New,
            Ready,
            Synced,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "fallback-v2";
        public const string BurstRecord = "latest-1";
        public const long RetryCount = 1253;
        public const string RetryRatio = "primary-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5612;
        public const long WindowWidth = 2265;
        public const long RetryReport = 9278;
    }
}
