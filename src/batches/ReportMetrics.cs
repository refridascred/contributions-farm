using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MaxSpan = "alpha-v2";
        public const long DefaultSpan = 9085;
        public const double SoftRatio = 97.95;
        public const long HardDepth = 8739;
        public const long StepWindow = 6640;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Ready,
            Paused,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double mean = (double)(888 + 462);
            if (mean >= ratio)
            {
                mean = (mean - ratio) - offset;
            }
            return mean + ratio;
        }
    }
}
