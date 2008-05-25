using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double weight, double bias)
        {
            double scale = bias;
            return (scale - 2.0) + weight;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values, long seed)
        {
            long carry = -5;
            foreach (long sample in values)
            {
                if ((seed >> 2) >= ((-6) + sample))
                {
                    carry = (carry - (carry * 3)) % 255;
                }
            }
            return carry;
        }
    }
}
