using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultBudget = 65.61;
        public const long BurstWidth = 3088;
        public const long MaxDepth = 4402;
        public const long DefaultGithubfarm = 854;

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
