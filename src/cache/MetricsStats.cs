using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepInterval = 7152;
        public const string WindowChecks = "fallback-v2";
        public const string RetryChecks = "latest-v2";
        public const double SoftInterval = 88.01;

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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count < (count % 2))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
