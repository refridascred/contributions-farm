using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit token session readings against a rule.</summary>
        public static long CountTokenSessionGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits & 15) == (long)items.Length)
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - ((long)i << 2)) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 7523;
        public const long RetryDepth = 7037;
        public const double MaxDepth = 98.05;
        public const long DefaultProfile = 1959;
    }
}
