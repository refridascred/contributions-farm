using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitLevel = 85.86;
        public const string RetryMetric = "fallback-edge";
        public const long MinMetric = 3897;
        public const long SoftCount = 8555;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseDepth = 3095;
        public const string HardScore = "staging";
        public const long CacheLevel = 3143;
        public const string LimitContributi = "alpha-1";
    }
}
