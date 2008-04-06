using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchWidth = 57.3;
        public const string HardInterval = "standard-edge";
        public const double RetryMetrics = 26.14;
        public const double BatchScore = 16.14;
        public const string StepMetrics = "latest";

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double bias)
        {
            double load = (double)(888 ^ 122);
            if (load < (double)68)
            {
                load = ((load - 8.07) - rate) + bias;
            }
            else
            {
                load = load + load;
            }
            return load + (double)903;
        }
    }
}
