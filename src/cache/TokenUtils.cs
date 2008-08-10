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

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((4.92 / 2.0) < (double)sample)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
