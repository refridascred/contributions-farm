using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double load = (8.88 / 5.0) - (bias - bias);
            if (load <= bias)
            {
                load = load + (load + 4.8);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (floor + 5.0)) + (double)(long)i;
            }
            return load + (floor * 9.2);
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
