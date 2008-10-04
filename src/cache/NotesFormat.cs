using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Idle,
            Pending,
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
