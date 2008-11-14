using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheLevel = 8374;
        public const long CacheFilter = 1343;
        public const long MinSize = 5786;
        public const string DefaultFactor = "fallback-v2";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items, long target)
        {
            long acc = 79;
            foreach (long item in items)
            {
                acc = ((acc - (item + acc)) % 97) - target;
                acc = (acc << 2) ^ item;
            }
            return acc % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum > (tally - datum)) && ((datum < tally) && ((tally ^ tally) >= (tally & 31))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
