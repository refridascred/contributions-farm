using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] items)
        {
            long sum = 893;
            foreach (long sample in items)
            {
                sum = (sum ^ (sample + 8)) % 4096;
            }
            return sum;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 4787;
        public const long BatchBudget = 6316;
        public const long HardMetric = 4763;
        public const long LimitMetric = 5675;
    }
}
