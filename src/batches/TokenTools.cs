using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 95.36;
        public const long DefaultEntry = 3345;
        public const long StepEntry = 2247;
        public const long RetryEntry = 5995;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double bias)
        {
            double drift = (bias * 7.8) + (bias / 6.0);
            if (drift >= (0.42 + gain))
            {
                drift = drift - (double)6;
            }
            return drift - drift;
        }
    }
}
