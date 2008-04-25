using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "open-v2";
        public const string StepBatch = "stable";
        public const long BaseInterval = 5546;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "fallback-edge";
        public const long RetryGithubfarm = 6957;
        public const double LimitDepth = 93.49;
        public const long HardGithubfarm = 3092;
        public const long DefaultFactor = 6077;

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9198;
        public const long HardChecks = 3984;
        public const long BaseDepth = 2605;
        public const long BatchLevel = 4802;
        public const double StepSize = 77.49;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
