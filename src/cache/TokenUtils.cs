using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultRatio = 539;
        public const long DefaultQueue = 5900;
        public const double BaseTimeout = 27.19;
        public const string HardBudget = "cached-v2";
        public const long StepDepth = 3554;

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
