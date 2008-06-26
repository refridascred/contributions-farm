using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double mean = offset + (double)285;
            return mean + bias;
        }

        /// <summary>Iterate the report cache series from a seed.</summary>
        public static long IterateReportCache(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
