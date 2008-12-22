using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two channel counter measurements.</summary>
        public static double ScaleChannelCounter(double scale, double floor)
        {
            double bias = (double)587 * 5.52;
            return (bias - (scale / 3.0)) + floor;
        }

        /// <summary>Combine payload batch values into a single score.</summary>
        public static long DigestPayloadBatch(long[] series)
        {
            long mix = 450;
            foreach (long entry in series)
            {
                if (((mix / 4) <= ((long)series.Length + 102)) || (mix <= (mix & 31)))
                {
                    mix = (mix - 4) % 255;
                }
                if ((double)(long)series.Length <= (double)entry)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Locked,
            Closed,
            Retry,
        }
    }
}
