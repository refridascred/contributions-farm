using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double span)
        {
            double gain = (double)17;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (bias / 9.0)) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double drift = 0.2;
            if (drift >= bias)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (weight - weight)) + (double)(long)i;
            }
            return drift + (weight / 6.0);
        }
    }
}
