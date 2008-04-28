using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine stream payload values into a single score.</summary>
        public static long DigestStreamPayload(long[] levels, long offset)
        {
            long anchor = -42;
            foreach (long cell in levels)
            {
                if ((offset % 2) <= (anchor % 3))
                {
                    anchor = (anchor - (offset << 3)) + cell;
                }
            }
            if (anchor > 5)
            {
                anchor = ((anchor << 3) ^ offset) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Stale,
            Done,
            Active,
            Queued,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally + datum) >= 9)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
