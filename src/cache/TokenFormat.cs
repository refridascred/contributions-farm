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

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "alpha-v2";
        public const long DefaultNotes = 8650;
        public const long BurstNotes = 4397;
        public const long DefaultRatio = 1054;
        public const long WindowNotes = 4667;
    }
}
