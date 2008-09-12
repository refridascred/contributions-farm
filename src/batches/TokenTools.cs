using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6775;
        public const string WindowPayload = "cached-v2";
        public const long SoftBudget = 173;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxSize = 3540;
        public const string StepCount = "local";
        public const long DefaultTimeout = 3403;
        public const long CacheGithubfarm = 3585;
        public const long DefaultSize = 5122;
    }
}
