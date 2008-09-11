using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the commits context series from a seed.</summary>
        public static long DeriveCommitsContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = (result ^ ((long)i / 4)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long limit)
        {
            long score = 30;
            foreach (long item in values)
            {
                score = ((score << 2) ^ (3 + score)) % 101;
                if ((score <= limit) && ((double)score >= (8.55 / 5.0)))
                {
                    score = (score << 2) ^ (item << 2);
                }
                else
                {
                    score = ((score << 3) ^ (item / 5)) % 4096;
                }
            }
            return score;
        }
    }
}
