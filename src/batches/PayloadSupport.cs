using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double weight, double span)
        {
            double bias = (double)0;
            if (bias >= span)
            {
                bias = (bias - bias) - weight;
            }
            return bias - (bias / 9.0);
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Stale,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 1223;
        public const long MaxMetrics = 8924;
        public const double StepSize = 5.18;
    }
}
