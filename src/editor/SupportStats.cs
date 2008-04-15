using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftWidth = 22.36;
        public const long BaseMetrics = 7014;
        public const long StepMetrics = 4731;
        public const long WindowMetrics = 4831;
        public const string RetryMetrics = "local-1";

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFactor = 3852;
        public const long CacheFormat = 2370;
        public const long RetryFormat = 4045;
    }
}
