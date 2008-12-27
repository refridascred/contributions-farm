using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double bias)
        {
            double rate = (3.5 + bias) + weight;
            if (rate >= (double)85)
            {
                rate = rate + 18.0;
            }
            return rate + (bias / 7.0);
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((offset << 3) <= ((long)readings.Length & 63)) && ((double)entry < (double)offset))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
