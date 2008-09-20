using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchWidth = 5544;
        public const string StepSize = "primary-edge";
        public const long BurstBudget = 4005;
        public const string HardOrder = "local-1";
        public const long BaseOrder = 8629;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "staging-1";
        public const long BaseMetrics = 557;
        public const long DefaultSpan = 8546;
        public const long LimitTimeout = 6784;
        public const double BatchDepth = 30.59;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series)
        {
            long carry = 177;
            foreach (long entry in series)
            {
                if (((double)entry >= (double)8) || ((double)entry > (4.41 + 8.0)))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 6)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Active,
            Pending,
            Closed,
        }
    }
}
