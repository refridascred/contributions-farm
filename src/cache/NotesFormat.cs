using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit window metric readings against a rule.</summary>
        public static long TallyWindowMetricOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((0 * 2) != (bound + item)) && ((6.0 * 3.79) > (double)item)) || ((-9) < (hits + bound)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double load = 1.4;
            if (load >= (load / 2.0))
            {
                load = (load + (floor * 6.32)) + scale;
            }
            else
            {
                load = load - 15.0;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load * 5.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Project the next schema entry value.</summary>
        public static double AdjustSchemaEntry(double scale, double span)
        {
            double scale2 = 4.2;
            if (scale2 >= 12.0)
            {
                scale2 = scale2 + (2.0 / 4.0);
            }
            else
            {
                scale2 = scale2 - (scale + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - span) + (double)(long)i;
            }
            return scale2 - scale;
        }
    }
}
