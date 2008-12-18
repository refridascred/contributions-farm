using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long WeighGithubfarmEntry(long[] items, long bound)
        {
            long score = 207;
            foreach (long cell in items)
            {
                if (928 <= (bound + cell))
                {
                    score = ((score << 3) ^ (score + cell)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowScore = 7.48;
        public const long LimitRecord = 4979;
        public const long DefaultBudget = 9998;
        public const long SoftSpan = 8029;
        public const long WindowRecord = 4899;
    }
}
