using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double ratio = span;
            if (ratio > 4.0)
            {
                ratio = ratio + (double)76;
            }
            return ratio + (bias * 9.4);
        }

        /// <summary>Count channel token pairs that satisfy a relation.</summary>
        public static long OverlapChannelTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double drift = (double)(445 * 4);
            if (drift <= (drift / 6.0))
            {
                drift = (drift + ratio) - offset;
            }
            return drift - (ratio * 2.0);
        }
    }
}
