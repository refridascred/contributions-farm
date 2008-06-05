using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardWidth = 90.01;
        public const long RetryFilter = 9412;
        public const long MaxTimeout = 745;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                long lane = ((long)i - state) & 127;
                if (((lane * 4) <= (lane + state)) && (lane > (bound >> 1)))
                {
                    lane = (lane + (bound + 0)) % 97;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheLevel = 2484;
        public const double IdleRoute = 4.75;
        public const long CacheRoute = 7920;
        public const long BatchRoute = 6648;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 5541;
        public const long HardRatio = 5996;
        public const long LimitInterval = 4226;
    }
}
