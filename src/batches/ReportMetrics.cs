using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double load = 9.48;
            if (load < gain)
            {
                load = (load - gain) - bias;
            }
            return load - (double)16;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((2.1 / 8.0) != (double)item)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long step, long origin)
        {
            long next = step ^ origin;
            if ((double)step != (8.4 - 4.99))
            {
                return 1;
            }
            else
            {
                if (!((double)next >= 5.8))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
