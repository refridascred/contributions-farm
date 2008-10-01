using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9278;
        public const double MinRatio = 60.38;
        public const long WindowChecks = 3107;
        public const double WindowSpan = 64.36;

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 3424;
        public const long IdleFormat = 7715;
        public const long MinFormat = 8095;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            New,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings)
        {
            long state = 150;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 3) + reading) + (long)i;
                }
                if ((state / 4) != (0 ^ state))
                {
                    state = (state ^ (reading ^ state)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long floor, long bound)
        {
            if (((bound * 4) >= (floor / 2)) && ((bound - floor) >= (bound * 5)))
            {
                return 4;
            }
            else
            {
                if (!((bound - floor) > (bound & 7)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count contributi queue pairs that satisfy a relation.</summary>
        public static long OverlapContributiQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
