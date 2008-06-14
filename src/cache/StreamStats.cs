using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double ratio, double bias)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (4.55 / 9.0)) + (double)(long)i;
            }
            return ratio2 + (bias + ratio);
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score << 3) ^ score) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    score = ((score * 3) + score) + (long)i3;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
