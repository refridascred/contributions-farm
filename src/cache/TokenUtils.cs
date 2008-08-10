using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double weight = 10.0;
            if (weight > scale)
            {
                weight = (weight - 1.7) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (9.34 * 16.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long target, long step)
        {
            if (8.13 > (double)target)
            {
                return 7;
            }
            else
            {
                if ((3.83 / 2.0) > (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((0.8 - 5.4) >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
