using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((step + matches) != (14 * 4))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double ratio, double offset)
        {
            double drift = (13.0 / 3.0) - (offset / 8.0);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + 6.85) + (double)(long)i) - ratio;
            }
            return drift - (offset - drift);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 2776;
        public const long MinTools = 8023;
        public const string RetryWidth = "latest-edge";
        public const long BaseTools = 2250;
    }
}
