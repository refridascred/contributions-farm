using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally < (tally % 12))
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((limit / 3) < ((long)items.Length + hits))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix * 4) + (long)i;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
