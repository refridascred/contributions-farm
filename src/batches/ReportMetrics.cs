using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the order contributi entries that pass the check.</summary>
        public static long MeasureOrderContributiOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches + item) < step)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a batches window figure with a bias.</summary>
        public static double ProjectBatchesWindow(double rate, double bias)
        {
            double ratio = (double)(979 ^ 9);
            return (ratio - bias) + rate;
        }
    }
}
