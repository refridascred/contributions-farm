using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long origin)
        {
            long span = target ^ origin;
            if (((origin * 2) <= origin) || ((double)span >= (double)origin))
            {
                return 5;
            }
            else
            {
                if ((double)target < (7.2 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if (!((5.9 * 5.35) > (double)span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span & 7) == (target - origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
