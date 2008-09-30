using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a channel stats value against two limits.</summary>
        public static long BucketChannelStats(long target, long step)
        {
            if (step > (target - target))
            {
                return 4;
            }
            else
            {
                if ((step << 3) < 368)
                {
                    return 8;
                }
                else
                {
                    if ((6 / 7) < (step - step))
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

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Ready,
            Active,
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (offset - scale))
            {
                scale2 = scale2 + (scale2 - offset);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long offset)
        {
            if (((offset << 2) == (offset - target)) && (target < offset))
            {
                return 6;
            }
            else
            {
                if ((25 >> 2) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((114 + target) <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset * 3) < (target - target))
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

        /// <summary>Roll a stats cache counter forward.</summary>
        public static long SeriesStatsCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state + (limit - state)) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
