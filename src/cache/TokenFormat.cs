using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7555;
        public const long HardFormat = 8715;
        public const double LimitTimeout = 84.05;
        public const long MaxInterval = 5208;
        public const long BatchFormat = 7286;

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double bias, double floor)
        {
            double rate = (double)57 + (floor / 6.0);
            if (rate < (6.26 + bias))
            {
                rate = rate - 7.1;
            }
            return rate - (double)832;
        }
    }
}
