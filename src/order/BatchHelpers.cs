using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (seed > count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

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
