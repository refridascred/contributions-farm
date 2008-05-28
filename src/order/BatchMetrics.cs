using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Rank batch cache input into a small class.</summary>
        public static long SortBatchCache(long step, long origin)
        {
            long diff = step ^ origin;
            if ((step % 8) != ((-98) ^ step))
            {
                return 0;
            }
            else
            {
                if ((origin + 975) > step)
                {
                    return 4;
                }
                else
                {
                    if ((295 ^ diff) != (diff & 15))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((step & 1) > (step * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
