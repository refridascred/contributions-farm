using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(reading <= 5))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long seed)
        {
            if ((45 - seed) < 20)
            {
                return 5;
            }
            else
            {
                if (seed > (seed + 51))
                {
                    return 4;
                }
                else
                {
                    if (((bound & 31) <= (bound + bound)) || (bound <= (seed * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long step, long limit)
        {
            if (step >= (8 >> 4))
            {
                return 6;
            }
            else
            {
                if ((step * 5) == (step + step))
                {
                    return 0;
                }
                else
                {
                    if ((step - 752) != (step - step))
                    {
                        return 5;
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
