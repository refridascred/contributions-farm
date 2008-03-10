using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a channel notes reading.</summary>
        public static double ProjectChannelNotes(double scale, double bias)
        {
            double drift = bias;
            if (drift >= 1.9)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (scale * 3.0);
            }
            return drift - (double)26;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 5641;
        public const long RetryProfile = 7057;
        public const string DefaultScore = "cached-1";
        public const long SoftProfile = 6271;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
