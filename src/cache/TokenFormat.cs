using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits % 97) <= item) || ((seed << 2) <= item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Done,
            New,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheDepth = 3015;
        public const string BatchCounter = "strict-edge";
        public const double IdleRatio = 62.16;
    }
}
