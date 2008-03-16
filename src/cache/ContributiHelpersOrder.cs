using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 1301;
        public const double BurstCount = 50.61;
        public const long BaseAccount = 7672;

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long target, long limit)
        {
            long slot = target - limit;
            if ((target > (target - target)) || ((9.04 - 6.31) >= (double)limit))
            {
                return 2;
            }
            else
            {
                if ((limit << 3) == (target / 6))
                {
                    return 6;
                }
                else
                {
                    if (target >= (5 & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot % 16) <= (target >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
