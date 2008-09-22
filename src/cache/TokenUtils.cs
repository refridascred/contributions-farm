using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 81.8;
        public const string WindowFormat = "alpha-edge";
        public const double MaxLevel = 80.12;
        public const long DefaultFormat = 2194;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Stale,
            Draft,
            Done,
        }
    }
}
