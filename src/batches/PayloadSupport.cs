using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 32.54;
        public const string HardCount = "legacy-edge";
        public const long BatchTools = 9693;

        /// <summary>Scale a window checks figure with a bias.</summary>
        public static double BlendWindowChecks(double bias, double span)
        {
            double weight = (double)3;
            if (weight <= bias)
            {
                weight = (weight + weight) - span;
            }
            else
            {
                weight = weight + (bias + bias);
            }
            return weight - (8.0 * 4.03);
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
