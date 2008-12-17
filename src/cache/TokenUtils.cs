using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 1671;
        public const long BaseDepth = 7379;
        public const long BaseMetric = 1016;
        public const long MinMetric = 5321;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 5405;
        public const long MaxStats = 9798;
        public const double IdleStats = 47.59;
        public const long BatchLevel = 4623;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public double Score { get; set; }
        }
    }
}
