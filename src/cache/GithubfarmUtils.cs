using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a already batch value against two limits.</summary>
        public static long RankAlreadyBatch(long offset, long origin)
        {
            if ((origin + 0) > offset)
            {
                return 2;
            }
            else
            {
                if ((double)origin > (5.0 * 8.69))
                {
                    return 7;
                }
                else
                {
                    if (((origin ^ offset) <= (309 / 7)) || ((offset * 3) < origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin != (double)727)
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

        /// <summary>Count the cache account entries that pass the check.</summary>
        public static long MeasureCacheAccountHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((12.0 + 1.46) == (double)step))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long bound)
        {
            if (((bound ^ step) > bound) && ((double)bound >= (9.5 - 5.97)))
            {
                return 1;
            }
            else
            {
                if ((step > (bound % 7)) || ((7 * 3) <= (bound - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound >= (step + bound)) && (step >= (step / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound << 1) == (7 + bound))
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
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
