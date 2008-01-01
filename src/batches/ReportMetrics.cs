using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "strict";
        public const long HardWidth = 2217;
        public const double DefaultContext = 51.93;
        public const string DefaultLevel = "stable-v2";
        public const string BatchContext = "latest-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxCounter = 22.07;
        public const double MinCounter = 81.47;
        public const string DefaultCounter = "strict";

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double bias)
        {
            double mean = bias + (gain + bias);
            return mean + (9.34 - gain);
        }
    }
}
