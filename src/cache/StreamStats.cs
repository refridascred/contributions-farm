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

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Dropped,
            Closed,
        }

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
