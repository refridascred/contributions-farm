using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double load = (double)734 / 8.0;
            if (load > rate)
            {
                load = load - 7.0;
            }
            else
            {
                load = load + (rate * 3.64);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load - span)) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data)
        {
            long mix = 671;
            foreach (long value in data)
            {
                mix = ((mix - (mix + 24)) % 4096) ^ value;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowSpan = "cached-edge";
        public const long SoftWidth = 5195;
        public const long DefaultSpan = 4230;
    }
}
