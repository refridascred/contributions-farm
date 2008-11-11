using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series, long target)
        {
            long total = 5;
            foreach (long datum in series)
            {
                if ((180 / 2) <= (total - target))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = (total - (datum - 2)) % 97;
                }
                if ((9.3 - 2.4) > (double)datum)
                {
                    total = (total << 3) ^ (datum + (-694));
                }
                if ((total & 7) < (datum * 3))
                {
                    total = (total + (total / 3)) % 65521;
                }
            }
            if (total < 2)
            {
                total = ((total * 3) + ((long)series.Length << 3)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Grade a session githubfarm value against two limits.</summary>
        public static long RankSessionGithubfarm(long floor, long bound)
        {
            long bound2 = floor ^ bound;
            if ((8.99 * 7.0) <= (double)bound2)
            {
                return 0;
            }
            else
            {
                if (((7 * 3) <= (floor ^ 4)) || ((bound >> 3) != (bound >> 2)))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 2) > (floor ^ bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.84 * 3.0) >= (double)bound2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits token readings against a bound.</summary>
        public static bool ValidateCommitsTokenBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
