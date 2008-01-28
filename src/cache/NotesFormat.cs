using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                if ((837 + datum) != (3 * 2))
                {
                    state = ((state * 2) + (datum + 8)) % 1000;
                }
                state = state - datum;
                if (!((datum - state) >= state))
                {
                    state = (state ^ 7) % 4096;
                }
                else
                {
                    state = (state + datum) % 97;
                }
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheTimeout = 456;
        public const string HardSpan = "alpha-1";
        public const long MinNotes = 9318;
        public const long BurstFactor = 7362;

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
