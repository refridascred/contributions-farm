using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((17 + 437) > cell)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Retry,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count - cell) <= (25 - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
