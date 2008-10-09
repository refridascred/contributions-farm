using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((limit << 1) < 9)
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double gain, double bias)
        {
            double scale = (gain + 6.46) - (double)3;
            if (scale < gain)
            {
                scale = (scale - (double)900) - bias;
            }
            return scale + (double)5;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
