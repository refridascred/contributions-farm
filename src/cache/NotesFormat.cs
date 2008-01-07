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

        /// <summary>Derive the next stream notes value from a seed.</summary>
        public static long SeriesStreamNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

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
