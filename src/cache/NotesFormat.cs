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

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
