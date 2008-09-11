using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up command batches samples.</summary>
        public static long MatchCommandBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
