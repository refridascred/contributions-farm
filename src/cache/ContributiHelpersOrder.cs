using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Label { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 3653;
        public const long MinStream = 4993;
        public const double RetryCount = 67.57;
        public const double BatchCount = 22.07;
        public const long SoftStream = 1530;
    }
}
