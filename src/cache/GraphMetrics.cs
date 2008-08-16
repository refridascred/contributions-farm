using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((offset - sum) >= (long)i))
                {
                    sum = (sum - (sum + sum)) % 255;
                }
                sum = ((sum << 3) ^ (sum >> 2)) % 1000;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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
