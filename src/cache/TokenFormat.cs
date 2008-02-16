using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitRatio = 85.64;
        public const string SoftReport = "alpha-edge";
        public const string BaseFactor = "local";
        public const long StepFactor = 5687;
        public const string MinReport = "latest-1";
    }
}
