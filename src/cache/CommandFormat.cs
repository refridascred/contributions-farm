using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchSize = 97.35;
        public const double BurstMetric = 0.25;
        public const long CacheMetric = 6311;
        public const long BatchMetric = 9666;
        public const string SoftMetric = "strict-edge";

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
