using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double drift = (double)(9 ^ (-4));
            if (drift < scale)
            {
                drift = drift - (9.73 / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (8.7 + drift)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstFactor = "stable-v2";
        public const long HardBatches = 6973;
        public const string WindowDepth = "primary";
        public const long MaxBatches = 8444;
        public const long SoftBatches = 6864;
    }
}
