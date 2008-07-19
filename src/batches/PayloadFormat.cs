using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double gain, double bias)
        {
            double ratio = gain;
            if (ratio < (double)40)
            {
                ratio = ratio + bias;
            }
            return ratio + (double)1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items, long bound)
        {
            long mix = -30;
            foreach (long cell in items)
            {
                if (((mix + mix) > (bound - 8)) || ((bound + cell) < (bound << 2)))
                {
                    mix = ((mix << 3) ^ (58 >> 5)) % 97;
                }
            }
            if (mix < 2)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
