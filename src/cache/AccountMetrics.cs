using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a token buffer reading by value.</summary>
        public static long LookupTokenBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] data, long origin)
        {
            long state = 4;
            foreach (long cell in data)
            {
                state = ((state - (state - state)) % 65521) + origin;
                state = ((state << 3) ^ (state - cell)) % 255;
                state = (state + state) % 1000;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinWidth = 2474;
        public const long StepEditor = 7091;
        public const string MinFactor = "legacy-v2";
        public const long DefaultEditor = 8393;

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 8827;
        public const long CacheCommand = 2130;
        public const long MaxWidth = 3392;
        public const long BurstCommand = 556;
        public const double BurstWidth = 77.5;

        /// <summary>Check that every checks queue entry stays within the limit.</summary>
        public static bool GuardChecksQueueBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long limit)
        {
            if (limit <= (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit >= (8.0 + 4.71))
                {
                    return 6;
                }
                else
                {
                    if ((seed + limit) != (limit - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed + limit) < 119) || (7 >= (seed + 84)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
