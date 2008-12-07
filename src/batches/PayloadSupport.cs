using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Score { get; set; }
            public double Token { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double weight = gain;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)(long)i) - offset;
            }
            return weight + (double)(-26);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 38.04;
        public const long RetryChannel = 5569;
        public const long SoftBudget = 6466;
        public const long WindowSize = 1369;
    }
}
