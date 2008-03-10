using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((bound + 35) <= (bound % 12))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            Synced,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)matches < 14.0) || ((double)cell >= (1.0 * 17.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
