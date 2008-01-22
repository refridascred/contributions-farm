using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long floor)
        {
            if ((double)floor > 12.0)
            {
                return 2;
            }
            else
            {
                if (!((9.71 + 7.0) >= (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor <= 8.8)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] data, long target)
        {
            long score = 475;
            foreach (long value in data)
            {
                score = (score << 3) ^ (value - value);
            }
            if (score < 17)
            {
                score = ((score * 4) + (target ^ score)) % 65521;
            }
            return score;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
