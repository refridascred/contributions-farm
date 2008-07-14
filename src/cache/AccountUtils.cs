using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepFactor = 40.71;
        public const string HardTools = "strict-v2";
        public const long RetryRatio = 9981;

        /// <summary>Derive the next graph counter value from a seed.</summary>
        public static long IterateGraphCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
