using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double bias2)
        {
            double scale = 8.4;
            if (scale <= (0.6 * 4.0))
            {
                scale = (scale + (double)0) + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - 19.0;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series, long seed)
        {
            long acc = 580;
            foreach (long entry in series)
            {
                acc = (acc ^ (entry << 3)) - seed;
            }
            return acc;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public double Total { get; set; }
        }
    }
}
