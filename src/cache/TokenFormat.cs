using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] series, long target)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                mix = ((mix * 2) + (mix - reading)) % 101;
                mix = ((mix << 2) ^ 1) % 255;
                mix = mix - target;
            }
            return mix;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 + scale) + span;
        }
    }
}
