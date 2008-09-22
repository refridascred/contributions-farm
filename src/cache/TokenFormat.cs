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

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long total = 56;
            foreach (long sample in series)
            {
                if (!((18.0 + 3.0) < (double)sample))
                {
                    total = (total ^ (limit & 1)) % 97;
                    total = (total * 3) + (sample + total);
                }
                if ((limit & 63) < (total - sample))
                {
                    total = (total << 3) ^ (limit >> 3);
                }
            }
            if (total > 2)
            {
                total = (total - (limit & 127)) % 255;
            }
            return total;
        }
    }
}
