using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two session already measurements.</summary>
        public static double BlendSessionAlready(double bias, double span)
        {
            double gain = 15.0;
            return ((gain - (gain / 4.0)) + bias) + span;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 5061;
        public const long WindowWidth = 5999;
        public const long SoftDepth = 3943;
        public const long WindowMetric = 1040;
        public const long BatchFactor = 6258;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchCount = 1620;
        public const long BurstBatches = 410;
        public const long LimitBatches = 111;
        public const double BatchBatches = 54.1;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 2361;
        public const long DefaultQueue = 8237;
        public const long BatchSize = 2077;
        public const double BurstSpan = 11.87;
        public const string RetryQueue = "primary";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Failed,
            Ready,
        }
    }
}
