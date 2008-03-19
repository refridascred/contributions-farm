using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] values)
        {
            long mark = 72;
            foreach (long sample in values)
            {
                mark = ((mark * 2) + (sample / 9)) % 4096;
            }
            if (mark < 491)
            {
                mark = (mark + (41 - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)bound > (1.03 + 16.0))
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
