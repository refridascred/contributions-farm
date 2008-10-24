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

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double gain2 = (gain + 2.26) * 12.0;
            if (gain2 < gain2)
            {
                gain2 = (gain2 + (gain2 * 15.0)) - bias;
            }
            return gain2 - (gain - 9.56);
        }
    }
}
