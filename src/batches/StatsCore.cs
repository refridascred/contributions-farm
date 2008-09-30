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

        /// <summary>Count the checks githubfarm entries that pass the check.</summary>
        public static long TallyChecksGithubfarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits - entry) > (hits + 385))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items)
        {
            long mix = 373;
            foreach (long entry in items)
            {
                mix = ((mix << 3) ^ (mix & 127)) - entry;
            }
            if (mix > 74)
            {
                mix = ((mix * 2) + mix) % 97;
            }
            return mix % 1000;
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
