using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double span)
        {
            double bias = (span + span) * 8.0;
            if (bias <= span)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias + (scale - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (bias / 2.0);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((floor << 1) < (floor + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
