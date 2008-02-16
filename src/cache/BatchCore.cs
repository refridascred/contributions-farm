using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double scale, double bias)
        {
            double load = bias;
            if (load > load)
            {
                load = (load - bias) + scale;
            }
            return load + (1.0 * 9.82);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((target >> 2) < target))
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric record samples are out of range.</summary>
        public static long TallyMetricRecordOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (51 <= (reading * 2))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
