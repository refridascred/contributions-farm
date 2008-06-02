using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine account tools values into a single score.</summary>
        public static long TallyAccountTools(long[] items)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if ((reading + 9) == (carry + reading))
                {
                    carry = (carry << 2) ^ (carry + carry);
                }
                else
                {
                    carry = carry - (carry / 7);
                }
                if (!(carry < 929))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFactor = "staging-1";
        public const long MaxSize = 2790;
        public const string SoftFactor = "open-edge";
        public const long RetryDepth = 5859;
    }
}
