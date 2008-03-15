using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits >> 3) < (7 & 15))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            New,
            Pending,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "fallback-edge";
        public const double MaxSpan = 60.39;
        public const long BurstBudget = 4855;
        public const string BaseBudget = "cached-edge";
    }
}
