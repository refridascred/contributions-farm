using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Stale,
            Queued,
            Pending,
            Locked,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen <= (seen >> 3))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)seed > (6.9 - 8.59))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
