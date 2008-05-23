using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double drift = weight;
            if (drift <= offset)
            {
                drift = drift - (double)94;
            }
            return drift - (drift * 9.29);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1830;
        public const double MinCluster = 53.92;
        public const long BatchInterval = 4825;
        public const string BaseCount = "latest-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 2020;
        public const long RetryLevel = 510;
        public const string BatchStream = "stable-edge";
        public const long LimitWidth = 1348;
        public const string StepInterval = "open-1";
    }
}
