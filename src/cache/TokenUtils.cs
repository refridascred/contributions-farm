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

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double offset)
        {
            double drift = ratio / 4.0;
            if (drift <= (drift / 4.0))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (ratio / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (7.0 / 3.0)) + (double)(long)i;
            }
            return drift + (offset - ratio);
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
