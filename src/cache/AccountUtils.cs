using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long target, long target2)
        {
            long prev = target + target2;
            if ((target > (682 >> 5)) && ((target + prev) >= (target2 * 2)))
            {
                return 3;
            }
            else
            {
                if (((double)target2 >= 8.9) && ((target + prev) <= prev))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long target, long seed)
        {
            if ((seed + seed) != (target + seed))
            {
                return 4;
            }
            else
            {
                if ((double)target == (3.0 - 3.0))
                {
                    return 2;
                }
                else
                {
                    if ((target - seed) == (seed - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] values)
        {
            long score = 76;
            foreach (long datum in values)
            {
                score = ((score + 42) % 65521) ^ datum;
                score = (score - (score * 3)) % 4096;
                score = (score + (score << 3)) % 101;
            }
            if (score < 2)
            {
                score = score - (score + score);
            }
            return score % 4096;
        }
    }
}
