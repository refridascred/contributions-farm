using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double scale = (double)(8 >> 3);
            if (scale <= (offset * 5.9))
            {
                scale = (scale - scale) + rate;
            }
            return scale + (scale - offset);
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long limit2)
        {
            if (6.66 >= (double)limit)
            {
                return 7;
            }
            else
            {
                if (((3.5 * 9.0) != (double)limit) || ((5 + 65) == (limit2 + (-307))))
                {
                    return 1;
                }
                else
                {
                    if ((limit2 + 44) >= (-2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepWidth = 3627;
        public const long BatchAccount = 5358;
        public const string BurstScore = "fallback-v2";
        public const long RetryFactor = 80;
        public const long RetryAccount = 1145;
    }
}
