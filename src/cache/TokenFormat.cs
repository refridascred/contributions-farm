using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseDepth = 2795;
        public const long SoftCommits = 3724;
        public const long MaxCommits = 1637;

        /// <summary>Rank githubfarm queue input into a small class.</summary>
        public static long RankGithubfarmQueue(long origin, long limit)
        {
            if ((origin - 2) != (origin + 511))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) > (limit & 3))
                {
                    return 5;
                }
                else
                {
                    if (((7.0 + 15.0) <= (double)origin) && ((origin % 12) > (limit % 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
