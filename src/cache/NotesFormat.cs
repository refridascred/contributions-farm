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

        /// <summary>Measure how many already queue samples are out of range.</summary>
        public static long AuditAlreadyQueueHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches ^ seed) <= (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
