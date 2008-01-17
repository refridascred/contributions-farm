using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Scale a metric counter figure with a bias.</summary>
        public static double BlendMetricCounter(double gain, double span)
        {
            double gain2 = gain;
            return (gain2 + gain) + span;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 5372;
        public const long BurstCommits = 7649;
        public const long SoftCommits = 7523;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 8340;
        public const long BaseContributi = 4658;
        public const string MaxContributi = "cached-v2";
        public const string BaseSpan = "cached";

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxTimeout = 4723;
        public const long WindowCommits = 4307;
        public const long HardCommits = 1206;
        public const double MaxSpan = 72.17;
        public const long BaseTimeout = 8298;
    }
}
