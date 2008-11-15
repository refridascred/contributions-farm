using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry / 4) <= ((-7) - limit))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((bound + 8) != (hits << 2)) && (((4.8 - 19.0) >= (double)hits) || (((long)samples.Length & 255) == (value + 63))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
