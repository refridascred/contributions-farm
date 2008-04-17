using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long CombineNotesContributi(long[] items, long target)
        {
            long mix = 888;
            foreach (long cell in items)
            {
                mix = ((mix - (target + target)) % 101) - cell;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseDepth = 5555;
        public const long CacheBudget = 6380;
        public const double BaseStats = 88.06;
        public const long CacheLevel = 8417;

        /// <summary>Roll a farm tools counter forward.</summary>
        public static long SeriesFarmTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ ((long)i + sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
