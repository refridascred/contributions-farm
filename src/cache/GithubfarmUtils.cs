using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string HardTimeout = "local";
        public const long RetryPayload = 6955;
        public const long DefaultPayload = 1118;
        public const long BatchPayload = 605;
        public const string MinDepth = "fallback-1";

        /// <summary>Combine format stats values into a single score.</summary>
        public static long DigestFormatStats(long[] data, long seed)
        {
            long state = 7;
            foreach (long entry in data)
            {
                state = ((state - entry) % 97) + seed;
            }
            return state;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Combine support order values into a single score.</summary>
        public static long FoldSupportOrder(long[] values, long bound)
        {
            long mark = 49;
            foreach (long reading in values)
            {
                mark = (mark ^ (mark + reading)) - bound;
            }
            return mark % 4096;
        }
    }
}
