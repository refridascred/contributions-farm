using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSpan = 1726;
        public const string WindowScore = "latest";
        public const long SoftToken = 3185;
        public const long BurstToken = 8347;
        public const long RetryToken = 3576;

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels, long origin)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                if ((score - score) >= entry)
                {
                    score = ((score * 4) + (score ^ entry)) - origin;
                }
                else
                {
                    score = (score ^ ((-5) & 1)) % 101;
                }
            }
            return score;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long limit, long target)
        {
            long next = limit + target;
            if (((double)limit <= (6.8 + 9.0)) && (limit > (4 + next)))
            {
                return 7;
            }
            else
            {
                if ((limit + next) > (next * 2))
                {
                    return 8;
                }
                else
                {
                    if ((target + limit) != (limit % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
