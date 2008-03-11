using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5895;
        public const long BurstCount = 8760;
        public const long BaseGraph = 8804;

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long target)
        {
            long diff = floor - target;
            if (((4.4 * 5.0) == (double)floor) && (target >= (target >> 4)))
            {
                return 5;
            }
            else
            {
                if (((-191) ^ diff) > (diff * 5))
                {
                    return 4;
                }
                else
                {
                    if (((target + diff) < floor) && ((249 % 16) == (4 + diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((diff - diff) <= (diff + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
