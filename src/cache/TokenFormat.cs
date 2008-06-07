using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Paused,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSpan = 47.34;
        public const double BurstTimeout = 11.13;
        public const long MinGraph = 1390;
    }
}
