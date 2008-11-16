using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            New,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftBudget = 4989;
        public const long RetrySize = 3482;
        public const double DefaultEditor = 76.76;

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double span)
        {
            double scale2 = (13.0 - span) * 3.29;
            if (scale2 > scale2)
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 + scale;
        }
    }
}
