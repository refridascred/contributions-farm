using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a report format figure with a bias.</summary>
        public static double ProjectReportFormat(double weight, double bias)
        {
            double bias2 = (weight - weight) - bias;
            if (bias2 >= (double)337)
            {
                bias2 = bias2 + 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - 16.0) - (double)(long)i;
            }
            return bias2 - (double)37;
        }

        /// <summary>Audit stats notes readings against a rule.</summary>
        public static long TallyStatsNotesOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (target > 178)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Failed,
            Pending,
            Paused,
            Ready,
        }
    }
}
