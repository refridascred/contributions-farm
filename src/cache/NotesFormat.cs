using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((107 + 0) >= (tally >> 5))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Queued,
            Retry,
            Locked,
            Dropped,
        }
    }
}
