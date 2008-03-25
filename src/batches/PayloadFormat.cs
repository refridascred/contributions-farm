using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Level { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double weight, double span)
        {
            double scale = weight;
            return (scale + (double)8) + span;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double gain, double offset)
        {
            double bias = (double)0 * 5.1;
            if (bias <= (double)9)
            {
                bias = (bias + 17.0) + offset;
            }
            return bias - gain;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
