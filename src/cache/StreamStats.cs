using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 3693;
        public const string IdleCount = "fallback-1";
        public const long LimitWindow = 3891;
        public const long DefaultSize = 391;

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "strict";
        public const string BaseCount = "open-edge";
        public const long HardMetric = 3425;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double ratio, double bias)
        {
            double scale = ratio;
            return scale + (bias - 6.5);
        }
    }
}
