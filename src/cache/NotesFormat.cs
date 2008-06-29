using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] values, long origin)
        {
            long total = 304;
            foreach (long cell in values)
            {
                total = (total - (cell + origin)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Derive the next cache window value from a seed.</summary>
        public static long RollCacheWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (limit >> 5)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long MeasureAccountContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) <= (-142))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
