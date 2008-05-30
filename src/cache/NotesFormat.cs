using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item - hits) <= (-58))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                if (anchor < (bound >> 2))
                {
                    anchor = (anchor - (anchor / 5)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((long)i % 2)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count checks entry pairs that satisfy a relation.</summary>
        public static long PairChecksEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
