using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepWidth = 69.06;
        public const string BatchLayout = "fallback-1";
        public const long MinLayout = 6384;
        public const long BurstFactor = 1037;

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double weight = (double)(224 >> 2);
            return ((weight - (weight * 6.38)) + gain) + bias;
        }
    }
}
