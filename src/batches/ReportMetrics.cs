using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepDepth = 3043;
        public const long MaxContributi = 6987;
        public const double RetryContributi = 38.55;
        public const string StepFactor = "fallback-v2";
        public const long SoftSpan = 6941;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double load = bias / 7.0;
            if (load > load)
            {
                load = (load - (load * 2.6)) + weight;
            }
            return load - (double)3;
        }

        /// <summary>Scale a layout window figure with a bias.</summary>
        public static double SmoothLayoutWindow(double scale, double bias)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load + scale)) - (double)(long)i;
            }
            return load - scale;
        }
    }
}
