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

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (!(floor > (floor + cur)))
            {
                return 5;
            }
            else
            {
                if (origin > floor)
                {
                    return 1;
                }
                else
                {
                    if (!((16.0 + 3.93) <= (double)cur))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
