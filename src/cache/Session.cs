using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of filter already readings.</summary>
        public static long ScoreFilterAlready(long[] levels, long seed)
        {
            long score = 278;
            foreach (long value in levels)
            {
                if ((double)score < 5.5)
                {
                    score = ((score ^ (value / 2)) % 255) - seed;
                }
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] samples, long step)
        {
            long anchor = 704;
            foreach (long item in samples)
            {
                anchor = (((anchor * 5) + item) % 65521) - step;
            }
            if (anchor < 785)
            {
                anchor = anchor ^ (259 & 63);
            }
            return anchor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long origin)
        {
            if (!((12.0 + 17.0) > (double)origin))
            {
                return 3;
            }
            else
            {
                if ((origin % 100) > limit)
                {
                    return 1;
                }
                else
                {
                    if ((61 ^ 3) != (limit + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
