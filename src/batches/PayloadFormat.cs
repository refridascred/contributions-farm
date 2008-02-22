using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "latest-edge";
        public const long BaseToken = 4075;
        public const string SoftToken = "latest";

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 2) ^ (seed + seed)) % 97;
                long matches = -44;
                if ((seed + seed) == (matches * 3))
                {
                    matches = ((matches * 4) + 4) % 255;
                }
                else
                {
                    anchor = (anchor - (matches % 8)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= (bias + bias))
            {
                gain2 = gain2 + 1.2;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (gain / 8.0)) + (double)(long)i;
            }
            return gain2 - gain2;
        }
    }
}
