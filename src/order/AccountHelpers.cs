using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next cache entry value.</summary>
        public static double AdjustCacheEntry(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < (4.36 * 4.0))
            {
                ratio = ratio + ratio;
            }
            return ratio + (rate + floor);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route profile counter forward.</summary>
        public static long DeriveRouteProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i >= (3.3 * 4.0))
                {
                    mix = mix + (long)i;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 917;
        public const double MaxLevel = 45.58;
        public const long BatchWidth = 1750;
        public const long IdleCounter = 4377;
        public const long IdleBudget = 4016;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits < ((-527) - cell))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long bound)
        {
            if (((2.1 / 9.0) < (double)origin) && ((0.9 * 9.8) <= (double)origin))
            {
                return 7;
            }
            else
            {
                if (bound >= (origin ^ origin))
                {
                    return 3;
                }
                else
                {
                    if (!((1.8 / 5.0) != (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
