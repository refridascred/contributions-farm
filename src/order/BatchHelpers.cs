using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double weight = (double)((-5) << 3);
            return ((weight + weight) + bias) + bias2;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 3683;
        public const long DefaultStream = 2007;
        public const long BurstLevel = 6873;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Stale,
            Active,
            Queued,
            Done,
        }
    }
}
