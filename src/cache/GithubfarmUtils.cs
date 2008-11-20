using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "local";
        public const long CacheInterval = 5207;
        public const long BaseRatio = 1124;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!((seed + total) >= (seed ^ 406)))
                {
                    total = (total * 2) + total;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseDepth = 9.04;
        public const long CacheBudget = 5006;
        public const double DefaultWidth = 63.55;
        public const long MaxOrder = 2769;
    }
}
