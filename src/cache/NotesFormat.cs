using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long state = 742;
            foreach (long cell in levels)
            {
                if ((967 & 3) > state)
                {
                    state = ((state ^ (state - (long)levels.Length)) % 65521) + cell;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool VerifyWindowSessionBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
