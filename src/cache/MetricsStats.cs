using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next filter stream value.</summary>
        public static double AdjustFilterStream(double weight, double span)
        {
            double load = weight;
            if (load > (16.0 / 7.0))
            {
                load = (load + (double)9) - span;
            }
            return load + weight;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values)
        {
            long mark = 4;
            foreach (long datum in values)
            {
                mark = ((mark + (mark & 255)) % 255) ^ datum;
            }
            return mark;
        }

        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long TallyGraphStatsGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((double)value != (double)seen) && ((double)seen <= (double)16))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Retry,
            Active,
        }
    }
}
