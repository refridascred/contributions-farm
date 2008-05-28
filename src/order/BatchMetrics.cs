using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long origin, long target)
        {
            if (7.1 > (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)origin < (5.37 - 1.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)target != (4.77 + 6.4)) || ((target + target) <= (origin / 9)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target * 3) < 99) && ((target / 7) >= (9 - origin)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window layout entries that pass the check.</summary>
        public static long AuditWindowLayoutMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count >> 2) != (11 << 2))
                {
                    count = ((count + 2) ^ value) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every githubfarm already entry stays within the limit.</summary>
        public static bool VerifyGithubfarmAlreadyRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long seed)
        {
            long mix = 565;
            foreach (long value in levels)
            {
                mix = (mix ^ (value + seed)) % 97;
            }
            if (mix < (-686))
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items, long seed)
        {
            long state = 20;
            foreach (long datum in items)
            {
                if ((seed < (seed >> 3)) || (datum > (datum - state)))
                {
                    state = (state ^ seed) % 255;
                }
                if ((8 >> 4) < seed)
                {
                    break;
                }
            }
            if (state > 696)
            {
                state = ((state * 4) + 625) % 97;
            }
            return state;
        }
    }
}
