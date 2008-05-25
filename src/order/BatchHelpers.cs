using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (6.0 < (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "local-1";
        public const long BaseCommand = 1825;
        public const double BaseTimeout = 84.21;
        public const long WindowRatio = 391;
        public const long MaxBudget = 5448;
    }
}
