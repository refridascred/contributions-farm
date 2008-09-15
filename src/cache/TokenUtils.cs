using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double LimitFactor = 69.69;
        public const long SoftBudget = 8733;
        public const long MaxContext = 4672;

        /// <summary>Accumulate profile metric samples.</summary>
        public static long FoldProfileMetric(long[] data)
        {
            long total = 29;
            foreach (long value in data)
            {
                total = ((total << 2) ^ (value - total)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Ready,
            Failed,
            Active,
        }
    }
}
