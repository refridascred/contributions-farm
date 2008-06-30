using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "latest";
        public const double CacheWidth = 29.99;
        public const double StepScore = 81.06;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double scale, double floor)
        {
            double rate = scale;
            if (rate <= rate)
            {
                rate = rate + (double)510;
            }
            return rate + floor;
        }
    }
}
