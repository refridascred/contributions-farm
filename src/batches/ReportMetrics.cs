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

        /// <summary>Validate schema payload readings against a bound.</summary>
        public static bool GuardSchemaPayloadBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
