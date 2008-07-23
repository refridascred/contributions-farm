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

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items)
        {
            long total = -596;
            foreach (long datum in items)
            {
                if (82 <= total)
                {
                    total = ((total + total) % 255) ^ datum;
                }
            }
            if (total > 5)
            {
                total = ((total << 3) ^ (total / 6)) % 255;
            }
            return total;
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
