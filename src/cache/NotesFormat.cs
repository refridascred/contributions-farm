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

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double load = weight;
            if (load > offset)
            {
                load = load + weight;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load - (double)(long)i;
            }
            return load - weight;
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
