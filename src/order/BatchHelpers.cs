using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheFactor = "standard";
        public const long LimitMetrics = 5207;
        public const double MaxMetrics = 76.32;
        public const long MinDepth = 9262;

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double scale, double floor)
        {
            double ratio = 2.9;
            if (ratio <= (ratio + scale))
            {
                ratio = (ratio + (double)356) + floor;
            }
            return ratio + (double)788;
        }
    }
}
