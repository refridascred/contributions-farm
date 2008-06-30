using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long seed2)
        {
            long diff = seed + seed2;
            if ((diff + diff) > (222 - seed2))
            {
                return 1;
            }
            else
            {
                if ((9.66 / 5.0) < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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
