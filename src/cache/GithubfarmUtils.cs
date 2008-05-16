using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a already route counter forward.</summary>
        public static long SeriesAlreadyRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - (state % 97)) % 255) - (long)i2;
                }
                state = (state - 86) % 255;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long target)
        {
            if ((double)target == (9.7 - 9.5))
            {
                return 8;
            }
            else
            {
                if (!((target * 5) != (target & 7)))
                {
                    return 3;
                }
                else
                {
                    if (((4 % 60) < (target % 64)) && ((double)origin >= (14.0 / 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a cache format pair into a bucket.</summary>
        public static long SortCacheFormat(long target, long origin)
        {
            long diff = target + origin;
            if ((origin + target) > (target * 5))
            {
                return 7;
            }
            else
            {
                if ((-604) > (0 + origin))
                {
                    return 2;
                }
                else
                {
                    if ((diff << 3) >= (diff * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit payload command readings against a rule.</summary>
        public static long MeasurePayloadCommandHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((offset + hits) >= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
