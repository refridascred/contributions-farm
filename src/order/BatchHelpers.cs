using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 88.86;
        public const double HardRoute = 70.99;
        public const long DefaultRoute = 6034;
        public const long CacheRoute = 1765;
        public const long BatchRoute = 8422;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 6397;
        public const long CacheChannel = 5447;
        public const long BurstCount = 2471;
    }
}
