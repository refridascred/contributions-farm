using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the order counter entries that pass the check.</summary>
        public static long MeasureOrderCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits > 146)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((404 * 4) > tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally < 3.2)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double mean = rate;
            if (mean > (0.2 / 9.0))
            {
                mean = mean + (double)57;
            }
            else
            {
                mean = mean + (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (floor / 7.0)) + (double)(long)i;
            }
            return mean - (11.0 / 7.0);
        }
    }
}
