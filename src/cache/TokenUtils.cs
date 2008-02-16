using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double weight, double floor)
        {
            double rate = (double)266 / 9.0;
            return (rate - weight) + floor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 8512;
        public const string DefaultCounter = "local";
        public const long RetryCounter = 2807;
        public const double SoftCounter = 41.93;
        public const long WindowCounter = 6225;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
