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

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long step, long floor)
        {
            long slot = step - floor;
            if ((double)floor >= (2.6 * 6.8))
            {
                return 5;
            }
            else
            {
                if (((step / 2) > slot) || ((double)floor > (3.48 + 8.7)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
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
