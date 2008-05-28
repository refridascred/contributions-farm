using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster session value from a seed.</summary>
        public static long RollClusterSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (seed % 97)) % 65521;
                state = state - (11 - state);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long CountCommitsFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((hits & 255) != (cell - 8)) || !((double)cell >= (4.0 - 9.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Synced,
            Pending,
        }
    }
}
