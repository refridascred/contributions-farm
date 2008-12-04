using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultCount = 2006;
        public const long DefaultFilter = 1868;
        public const string BatchFilter = "strict-v2";
        public const long MaxCount = 7124;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBudget = "legacy-v2";
        public const double LimitBuffer = 71.15;
        public const long BaseBuffer = 4378;
        public const long RetryBuffer = 3599;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleScore = 7565;
        public const double StepTimeout = 76.04;
        public const string IdleSession = "fallback-edge";
        public const long BurstSession = 706;
    }
}
