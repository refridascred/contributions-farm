using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Failed,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 6908;
        public const double BaseMetric = 4.38;
        public const double HardCount = 70.04;
        public const long BurstTimeout = 1378;

        /// <summary>Adjust a format report reading.</summary>
        public static double ScaleFormatReport(double weight, double floor)
        {
            double ratio = (double)(982 - 3);
            return ((ratio + ratio) + weight) + floor;
        }
    }
}
