using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long TallyMetricsLayoutMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((bound - bound) != (tally >> 2)))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value < (target << 3)) || ((190 >> 2) >= target)) && ((double)value == (5.0 - 0.1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
