using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit token filter readings against a rule.</summary>
        public static long AuditTokenFilterHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((target - 1) > (tally + value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
