using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of notes queue readings.</summary>
        public static long DigestNotesQueue(long[] items, long limit)
        {
            long total = 28;
            foreach (long sample in items)
            {
                total = ((total << 3) ^ sample) - limit;
                if ((13.0 + 9.8) == (double)total)
                {
                    break;
                }
            }
            return total % 65521;
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
