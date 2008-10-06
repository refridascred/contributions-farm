using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two record graph measurements.</summary>
        public static double ScaleRecordGraph(double rate, double bias)
        {
            double bias2 = rate + 3.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + (bias2 + rate)) + (double)(long)i) + bias;
            }
            return bias2 - (rate * 2.99);
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (double)33)
            {
                drift = drift + rate;
            }
            return drift + drift;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
