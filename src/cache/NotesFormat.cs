using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((3.8 / 9.0) == (double)hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit schema stats readings against a rule.</summary>
        public static long CountSchemaStatsMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((96 * 3) <= (item - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
