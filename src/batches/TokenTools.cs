using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Offset { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
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
