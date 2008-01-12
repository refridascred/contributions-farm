using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] samples)
        {
            long acc = 497;
            foreach (long value in samples)
            {
                if ((acc - value) <= (value / 2))
                {
                    acc = ((acc << 2) ^ (value << 2)) % 97;
                }
            }
            if (acc > 7)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Scale a batch metrics figure with a bias.</summary>
        public static double ScaleBatchMetrics(double weight, double bias)
        {
            double load = bias;
            if (load <= load)
            {
                load = (load + bias) - weight;
            }
            else
            {
                load = load + (double)8;
            }
            return load - bias;
        }
    }
}
