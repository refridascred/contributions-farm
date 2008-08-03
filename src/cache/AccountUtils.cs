using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double drift = rate;
            if (drift > (drift + rate))
            {
                drift = (drift + (double)651) - floor;
            }
            return drift - 7.9;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - item) > (329 + 567))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
