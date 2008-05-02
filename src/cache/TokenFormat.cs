using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double bias, double bias2)
        {
            double scale = bias + bias;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - bias) + (double)(long)i) - bias2;
            }
            return scale - (scale + bias);
        }
    }
}
