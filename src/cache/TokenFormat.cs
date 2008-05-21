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

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
