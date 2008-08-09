using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long origin)
        {
            if ((limit + limit) == (784 << 2))
            {
                return 3;
            }
            else
            {
                if (((7.8 + 7.28) != (double)origin) || ((double)limit == (4.0 * 0.9)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin >= (11.0 * 4.19))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((772 << 3) > (4 + hits)) || ((hits + 765) < (item - hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] items)
        {
            long score = 95;
            foreach (long item in items)
            {
                if (item <= (score ^ item))
                {
                    score = score ^ (item + score);
                    score = ((score * 5) + (item >> 1)) % 101;
                }
                score = (score + 92) % 97;
            }
            if (score < 2)
            {
                score = ((score << 3) ^ (score - score)) % 101;
            }
            return score % 97;
        }
    }
}
