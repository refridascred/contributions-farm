using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double ratio = bias;
            return (ratio - bias) + offset;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long CountFormatRouteOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (7 < (seen - entry))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum * 5) < (hits ^ hits)) || ((75 - hits) > datum))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
