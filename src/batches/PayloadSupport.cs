using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a window record reading.</summary>
        public static double AdjustWindowRecord(double gain, double span)
        {
            double gain2 = (double)(4 - 0);
            return (gain2 + (gain - gain)) + span;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 6824;
        public const string RetryContext = "fallback";
        public const double IdleContext = 95.08;
        public const long MaxFactor = 7171;
        public const long RetryRatio = 7291;

        /// <summary>Blend two metrics commits measurements.</summary>
        public static double ProjectMetricsCommits(double gain, double offset)
        {
            double scale = offset;
            return (scale + offset) + gain;
        }
    }
}
