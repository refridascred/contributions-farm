using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ acc) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long step, long floor)
        {
            long next = step - floor;
            if (!((next + floor) >= (floor / 3)))
            {
                return 7;
            }
            else
            {
                if ((step ^ 3) == (next - step))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheWidth = 73.58;
        public const double CacheGraph = 6.22;
        public const long BatchSpan = 2605;
        public const long SoftDepth = 7039;
        public const double BaseGraph = 74.65;
    }
}
