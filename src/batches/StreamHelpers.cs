using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            New,
            Synced,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheDepth = "standard";
        public const long StepWidth = 2375;
        public const double BaseStream = 31.06;
        public const string LimitWidth = "legacy";

        /// <summary>Derive the next token githubfarm value from a seed.</summary>
        public static long SeriesTokenGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long TallyToolsNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((76 / 6) == ((-3) - tally))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
