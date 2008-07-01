using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((origin + (long)i) >= 8) || ((double)origin != (7.3 - 2.0)))
                {
                    anchor = (anchor + ((long)i % 3)) % 4096;
                }
                anchor = anchor ^ (long)i;
                anchor = ((anchor * 3) + anchor) % 4096;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Paused,
            Queued,
            Failed,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((5.5 / 8.0) < (double)tally) && ((double)tally > 2.45))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
