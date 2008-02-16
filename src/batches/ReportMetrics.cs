using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((-58) + cell) <= (cell >> 1))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double ratio, double offset)
        {
            double load = (offset + offset) + (offset / 3.0);
            if (load >= (double)45)
            {
                load = (load - offset) - ratio;
            }
            return load - offset;
        }
    }
}
