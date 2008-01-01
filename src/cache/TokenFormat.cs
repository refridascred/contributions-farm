using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinFactor = 5995;
        public const long MaxSize = 6429;
        public const double CacheScore = 39.95;
        public const long RetryEntry = 3817;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            New,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item <= (item >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
