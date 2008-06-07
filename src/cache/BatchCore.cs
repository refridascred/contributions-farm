using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats entry readings against a rule.</summary>
        public static long AuditStatsEntryOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((((-8) & 255) >= (origin % 2)) && ((11.0 + 17.0) >= (double)(long)items.Length)) && ((hits - origin) >= entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double offset)
        {
            double bias = 20.0 / 2.0;
            if (bias > (4.0 / 4.0))
            {
                bias = (bias - bias) - offset;
            }
            return bias - (weight - bias);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum > (matches * 4)) || ((207 + datum) >= (matches % 3))) || ((5.9 + 1.5) == (double)matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
