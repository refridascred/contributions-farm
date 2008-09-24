using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7855;
        public const long LimitRoute = 9612;
        public const string DefaultCount = "alpha-v2";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((4 ^ bound) < bound)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double load = floor;
            if (load <= (load - scale))
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load + (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
