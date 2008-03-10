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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((floor * 5) < (3 << 1))
                {
                    result = result - 7;
                }
                long gap = (floor >> 2) % 60;
                result = (result ^ (473 ^ gap)) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
