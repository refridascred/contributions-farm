using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank tools buffer input into a small class.</summary>
        public static long SortToolsBuffer(long seed, long offset)
        {
            long cur = seed + offset;
            if ((double)seed <= 8.9)
            {
                return 6;
            }
            else
            {
                if (cur < offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values, long step)
        {
            long carry = -12;
            foreach (long item in values)
            {
                if ((item <= (89 + step)) || ((768 * 4) >= step))
                {
                    carry = carry - item;
                }
                if ((item + (long)values.Length) == (step + (-121)))
                {
                    carry = (carry + (item * 4)) % 65521;
                }
            }
            if (carry < 939)
            {
                carry = ((carry * 5) + (carry & 1)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 5564;
        public const double DefaultProfile = 32.57;
        public const double CacheBudget = 11.91;
    }
}
