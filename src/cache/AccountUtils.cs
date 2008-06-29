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

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryRatio = 9646;
        public const double BatchScore = 88.45;
        public const double MaxCounter = 88.98;
        public const long StepScore = 9497;

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
