using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Token { get; set; }
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 4517;
        public const string LimitFactor = "staging";
        public const long IdleCluster = 3318;
        public const double CacheBudget = 24.72;
        public const long SoftCluster = 6180;

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 5367;
        public const long BaseLayout = 4387;
        public const double RetryDepth = 50.29;
    }
}
