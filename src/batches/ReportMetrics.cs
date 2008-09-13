using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!((117 ^ mark) < ((long)i & 127)))
                {
                    mark = ((mark * 2) + (origin << 3)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double bias, double span)
        {
            double rate = (double)(6 % 2);
            if (rate >= bias)
            {
                rate = rate + (double)573;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate - 3.6;
        }
    }
}
