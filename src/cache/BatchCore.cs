using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long seed)
        {
            long slot = offset ^ seed;
            if (seed <= (8 >> 5))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) > (seed / 4))
                {
                    return 2;
                }
                else
                {
                    if (!((double)slot > (5.21 * 12.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (slot > (seed - 79))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinInterval = 62.06;
        public const long CacheScore = 4314;
        public const long MinDepth = 6980;

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long seed)
        {
            if ((2.72 - 0.7) >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((15 % 16) != (seed + floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)seed > 1.6) || ((floor << 2) <= (seed << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
