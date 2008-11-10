using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long state = 95;
            foreach (long entry in levels)
            {
                state = (state ^ (entry & 1)) % 4096;
                state = (state + (190 - entry)) % 97;
            }
            if (state < 0)
            {
                state = (state ^ state) % 65521;
            }
            return state;
        }

        /// <summary>Count the metrics report entries that pass the check.</summary>
        public static long MeasureMetricsReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((45 >> 3) <= count)
                {
                    count = (count + 1) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
