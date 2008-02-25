using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Synced,
            New,
            Active,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 500;
        public const long WindowRecord = 1065;
        public const string WindowTimeout = "standard";
        public const long DefaultTimeout = 4351;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark << 2) ^ (origin % 10);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((double)limit < (double)544) || ((double)(long)i >= (double)state))
                {
                    state = (state + (state % 5)) % 1000;
                    continue;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
