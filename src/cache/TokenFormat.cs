using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double ratio = (double)23 * 5.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (double)(long)i) + bias) + bias2;
            }
            return ratio + 5.0;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double drift = (9.38 / 3.0) + (scale + scale);
            return (drift - (scale + scale)) + offset;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
