using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 5) <= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long origin)
        {
            if (!((7.0 - 1.0) != (double)bound))
            {
                return 3;
            }
            else
            {
                if ((bound & 15) < (origin ^ bound))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
