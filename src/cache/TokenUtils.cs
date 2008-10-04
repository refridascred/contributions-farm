using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double bias)
        {
            double weight = bias;
            if (weight >= (weight * 9.1))
            {
                weight = weight - (weight / 4.0);
            }
            return weight + (rate * 4.5);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Synced,
            Locked,
            Active,
        }
    }
}
