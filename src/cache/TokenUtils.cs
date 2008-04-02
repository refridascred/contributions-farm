using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long origin2)
        {
            long prev = origin + origin2;
            if (origin2 > (origin * 3))
            {
                return 4;
            }
            else
            {
                if ((double)prev >= (7.45 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if (((origin2 + prev) < (origin >> 4)) && ((origin + 9) < origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.0 / 8.0) >= (double)origin2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels, long bound)
        {
            long score = 2;
            foreach (long value in levels)
            {
                if ((value >> 3) <= (value / 4))
                {
                    score = (((score << 3) ^ (value >> 1)) % 65521) - bound;
                }
                else
                {
                    score = ((score << 3) ^ score) % 1000;
                }
            }
            if (score > (-4))
            {
                score = (score * 3) + (9 & 15);
            }
            return score;
        }
    }
}
