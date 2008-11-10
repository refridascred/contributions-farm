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

        /// <summary>Combine token stats values into a single score.</summary>
        public static long TotalTokenStats(long[] values)
        {
            long result = 0;
            foreach (long reading in values)
            {
                if ((747 - reading) == (result - result))
                {
                    result = (result << 2) ^ (result + reading);
                }
                else
                {
                    result = result ^ 68;
                }
                result = (result - (924 & 15)) % 97;
            }
            if (result > 0)
            {
                result = result - (6 & 1);
            }
            return result;
        }
    }
}
