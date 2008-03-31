using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a stream channel reading.</summary>
        public static double ScaleStreamChannel(double gain, double offset)
        {
            double drift = (double)((-3) + 2);
            if (drift >= offset)
            {
                drift = (drift - offset) - gain;
            }
            return drift - (double)71;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - (double)32;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
