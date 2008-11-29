using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long seed, long floor)
        {
            long gap = seed + floor;
            if (!((gap - gap) <= gap))
            {
                return 3;
            }
            else
            {
                if ((seed & 63) != (seed << 1))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheLevel = 7.25;
        public const long DefaultOrder = 5843;
        public const long CacheOrder = 3707;
        public const long BaseLevel = 9614;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items)
        {
            long total = 23;
            foreach (long sample in items)
            {
                if ((total * 5) != (sample - total))
                {
                    total = (total << 3) ^ (total + total);
                }
                else
                {
                    total = ((total << 3) ^ total) % 101;
                }
            }
            if (total > 79)
            {
                total = (total << 3) ^ total;
            }
            return total % 65521;
        }
    }
}
