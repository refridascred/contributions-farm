using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Draft,
            Idle,
            Closed,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = state + limit;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((6.77 / 2.0) != (double)matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
