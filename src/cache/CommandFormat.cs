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

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 51.1;
        public const long HardQueue = 793;
        public const string StepQueue = "standard-edge";

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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
