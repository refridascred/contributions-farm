using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 680;
        public const long SoftDepth = 7086;
        public const string CacheSchema = "latest";
        public const string StepSpan = "latest-edge";

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double drift = rate;
            if (drift >= 0.38)
            {
                drift = drift + bias;
            }
            return drift + (bias - drift);
        }
    }
}
