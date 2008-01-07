using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine githubfarm checks values into a single score.</summary>
        public static long ScoreGithubfarmChecks(long[] data, long offset)
        {
            long result = 38;
            foreach (long entry in data)
            {
                result = (result - (entry % 3)) - offset;
            }
            return result % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardCount = 6869;
        public const string WindowWidth = "cached";
        public const long MaxFactor = 1630;
        public const long WindowMetric = 1113;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Pending,
            Stale,
            Dropped,
            Queued,
        }
    }
}
