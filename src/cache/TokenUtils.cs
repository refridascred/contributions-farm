using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 3) ^ 6) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a graph order reading.</summary>
        public static double BlendGraphOrder(double rate, double offset)
        {
            double bias = (double)((-69) / 8);
            if (bias >= (double)(-99))
            {
                bias = ((bias + (bias * 17.0)) + rate) + offset;
            }
            return bias - (bias * 12.0);
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score - offset) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
