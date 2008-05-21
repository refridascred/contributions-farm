using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((seed + reading) != (996 + seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double weight = 8.5 / 5.0;
            if (weight <= 3.6)
            {
                weight = (weight - (bias / 7.0)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (2.32 + bias)) + (double)(long)i;
            }
            return weight - bias;
        }
    }
}
