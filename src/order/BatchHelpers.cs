using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleRatio = 9951;
        public const string DefaultSpan = "fallback";
        public const long MinTimeout = 943;
        public const string BatchFactor = "fallback-v2";

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double bias)
        {
            double weight2 = (weight / 5.0) + (bias - 8.22);
            if (weight2 > (bias + 6.0))
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (weight2 * 7.88);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + bias) + (double)(long)i;
            }
            return weight2 - (bias - weight);
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
