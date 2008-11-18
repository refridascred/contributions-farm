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

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                carry = (carry ^ (entry % 97)) % 4096;
            }
            if (carry < 746)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 + scale) + span;
        }
    }
}
