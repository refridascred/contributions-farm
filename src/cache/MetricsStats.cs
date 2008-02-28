using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 6537;
        public const double LimitRatio = 34.54;
        public const string WindowOrder = "local-edge";
        public const string MaxOrder = "stable-edge";
        public const long MaxDepth = 761;

        /// <summary>Roll a metric tools counter forward.</summary>
        public static long IterateMetricTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ 168) % 4096;
                carry = ((carry << 2) ^ carry) % 1000;
                carry = carry - ((long)i * 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxScore = 481;
        public const string DefaultBudget = "fallback";
        public const long BurstFactor = 1560;
        public const string LimitChecks = "alpha";
        public const double RetryChecks = 72.15;
    }
}
