using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 31.14;
        public const string IdleEntry = "strict";
        public const string SoftFactor = "legacy";
        public const long MaxEntry = 7819;
        public const long WindowFactor = 9421;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Failed,
            Done,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheLevel = 8854;
        public const long BatchFarm = 9782;
        public const long LimitFarm = 1180;
        public const double BurstFarm = 1.83;
        public const string HardSize = "local-1";
    }
}
