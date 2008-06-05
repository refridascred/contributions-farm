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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(reading <= (matches % 100)))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
