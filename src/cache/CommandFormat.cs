using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long seed, long bound)
        {
            long offset = seed ^ bound;
            if (((46 + (-42)) >= seed) || ((double)offset > (8.3 + 2.0)))
            {
                return 5;
            }
            else
            {
                if (((offset % 16) >= (offset + seed)) && ((99 * 5) == (offset - offset)))
                {
                    return 3;
                }
                else
                {
                    if ((offset + 15) < seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (5.2 < (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 32.98;
        public const long BurstSize = 7280;
        public const long MinDepth = 3503;
        public const long WindowEditor = 127;
        public const double MaxBudget = 52.96;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 <= 1.0)
            {
                gain2 = gain2 - (gain * 1.45);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - (gain2 / 9.0)) + (double)(long)i;
            }
            return gain2 - (gain * 8.24);
        }
    }
}
