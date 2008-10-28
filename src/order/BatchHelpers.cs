using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9 << 1) <= (603 - count))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double weight = span;
            if (weight >= (double)46)
            {
                weight = (weight + (double)426) - rate;
            }
            return weight - (span * 1.3);
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
