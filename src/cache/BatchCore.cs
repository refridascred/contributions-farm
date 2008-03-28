using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a cache context value against two limits.</summary>
        public static long SortCacheContext(long floor, long seed)
        {
            if (((double)seed != (4.94 / 2.0)) || (((-6) ^ seed) >= floor))
            {
                return 2;
            }
            else
            {
                if (((floor / 6) <= (seed + 22)) && ((seed >> 4) < (seed >> 3)))
                {
                    return 6;
                }
                else
                {
                    if ((floor + 63) == (floor % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 5197;
        public const long IdleRatio = 9837;
        public const long LimitRatio = 3328;
    }
}
