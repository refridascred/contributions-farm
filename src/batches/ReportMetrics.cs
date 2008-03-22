using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowSpan = 8581;
        public const long MinInterval = 8502;
        public const string BatchTimeout = "open-1";

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double weight = (double)(-3);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 15.0) - (double)(long)i;
            }
            return weight + (bias - floor);
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Queued,
            New,
        }
    }
}
