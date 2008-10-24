using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxSize = 7147;
        public const string DefaultToken = "legacy-v2";
        public const string IdleToken = "primary-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseInterval = 77.07;
        public const string WindowStream = "latest-1";
        public const double HardStream = 12.6;
        public const string IdleStream = "primary-v2";

        /// <summary>Scale a metrics editor figure with a bias.</summary>
        public static double BlendMetricsEditor(double gain, double floor)
        {
            double scale = floor;
            if (scale >= (double)966)
            {
                scale = scale + (scale - floor);
            }
            else
            {
                scale = scale - (double)8;
            }
            return scale + (gain * 2.0);
        }
    }
}
