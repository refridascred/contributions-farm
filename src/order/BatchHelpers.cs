using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-v2";
        public const double BurstGithubfarm = 90.49;
        public const double StepTimeout = 20.02;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryCount = 47.56;
        public const string HardCount = "legacy-1";
        public const string LimitRatio = "fallback-edge";
        public const long RetrySpan = 7801;
        public const long StepTools = 8544;
    }
}
