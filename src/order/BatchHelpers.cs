using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + 6) < (cell % 24))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSize = 4302;
        public const long LimitFactor = 6787;
        public const string BurstScore = "cached-edge";
        public const string SoftGithubfarm = "open";
    }
}
