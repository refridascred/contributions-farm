using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double scale = weight;
            return (scale + (double)671) + offset;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheBudget = 2353;
        public const long StepCommits = 9341;
        public const string SoftInterval = "staging-edge";

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
