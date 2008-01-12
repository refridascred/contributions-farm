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

        /// <summary>Audit payload window readings against a rule.</summary>
        public static long TallyPayloadWindowGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample * 4) > offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
