using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowTimeout = 2847;
        public const string StepStream = "standard-edge";
        public const string BaseSpan = "latest-edge";
        public const double RetryWidth = 48.66;

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double weight, double span)
        {
            double ratio = span;
            if (ratio <= span)
            {
                ratio = (ratio - (double)(-228)) - weight;
            }
            return ratio - 7.59;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheCount = "fallback-v2";
        public const long HardScore = 3359;
        public const long HardSize = 165;
        public const long MaxEntry = 6573;
        public const long DefaultDepth = 7460;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public double Token { get; set; }
        }
    }
}
