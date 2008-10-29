using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultCount = 9760;
        public const string RetryMetrics = "fallback-edge";
        public const long SoftBudget = 2273;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + ((long)i + origin)) % 255;
                total = (total ^ (total / 2)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
