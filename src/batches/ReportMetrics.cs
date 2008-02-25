using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "open-1";
        public const string BatchCount = "open";
        public const double BurstReport = 32.35;
        public const double MaxReport = 64.28;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double gain, double offset)
        {
            double gain2 = gain / 6.0;
            for (int i = 0; i < 4; i++)
            {
                gain2 = ((gain2 - (gain2 * 1.0)) + (double)(long)i) + offset;
            }
            return gain2 + gain;
        }
    }
}
