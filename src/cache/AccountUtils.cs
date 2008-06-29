using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a command context figure with a bias.</summary>
        public static double ScaleCommandContext(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (double)(long)i) - weight;
            }
            return ratio + ratio;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long limit)
        {
            long span = offset - limit;
            if ((889 / 8) == (span + limit))
            {
                return 8;
            }
            else
            {
                if ((offset ^ offset) >= (limit * 5))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a stats profile sample.</summary>
        public static long FindStatsProfileIndex(long[] items, long floor)
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
    }
}
