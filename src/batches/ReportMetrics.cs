using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double gain, double floor)
        {
            double mean = (double)35 / 8.0;
            if (mean >= (floor * 5.33))
            {
                mean = mean + (4.0 - gain);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (4.0 + floor)) + (double)(long)i;
            }
            return mean - (double)384;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 3104;
        public const double MinCluster = 20.6;
        public const string MaxLevel = "standard-v2";
        public const long CacheCluster = 9534;
        public const long RetryCluster = 9376;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Retry,
            Closed,
            Active,
            Draft,
        }
    }
}
