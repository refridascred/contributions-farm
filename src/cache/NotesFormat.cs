using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Audit layout record readings against a rule.</summary>
        public static long CountLayoutRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally >= (4.4 - 4.9))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi context value against two limits.</summary>
        public static long RankContributiContext(long target, long origin)
        {
            long next = target - origin;
            if ((double)origin == (double)next)
            {
                return 6;
            }
            else
            {
                if ((origin + 496) > (544 ^ 0))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
