using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order notes entries that pass the check.</summary>
        public static long AuditOrderNotesGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (80 >= (datum / 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double bias2 = floor;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (double)959) + (double)(long)i) + bias;
            }
            return bias2 - 3.0;
        }
    }
}
