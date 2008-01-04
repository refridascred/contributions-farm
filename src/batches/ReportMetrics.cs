using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "local-1";
        public const long MinCount = 3840;
        public const string HardCache = "cached-edge";
        public const long LimitInterval = 8713;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double mean = rate;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)(long)i) - floor;
            }
            return mean - (double)3;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Draft,
            Failed,
            Ready,
        }
    }
}
