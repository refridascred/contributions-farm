using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstFactor = "legacy-edge";
        public const long StepOrder = 1376;
        public const double BatchOrder = 29.85;
        public const long SoftTimeout = 7086;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 1009;
        public const long SoftGithubfarm = 9851;
        public const long IdleGithubfarm = 6443;
    }
}
