using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a format githubfarm value against two limits.</summary>
        public static long SortFormatGithubfarm(long step, long step2)
        {
            long edge = step + step2;
            if ((step2 & 127) > step2)
            {
                return 0;
            }
            else
            {
                if ((edge / 3) != (step ^ step))
                {
                    return 8;
                }
                else
                {
                    if ((double)996 < (double)edge)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.0 / 6.0) != (double)edge)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
