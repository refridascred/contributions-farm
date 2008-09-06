using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetrySpan = 5428;
        public const double RetryMetric = 50.54;
        public const double MaxMetric = 97.93;
        public const long IdleMetric = 3018;

        /// <summary>Combine session report values into a single score.</summary>
        public static long CombineSessionReport(long[] samples)
        {
            long carry = 772;
            foreach (long datum in samples)
            {
                carry = (carry + datum) % 1000;
            }
            if (carry > 699)
            {
                carry = ((carry << 3) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "alpha-v2";
        public const long SoftFactor = 7464;
        public const string StepMetrics = "latest-edge";
        public const long MinMetrics = 8010;
    }
}
