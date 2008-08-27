using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 2545;
        public const string BurstScore = "staging-edge";
        public const string LimitTimeout = "strict-v2";

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] items)
        {
            long carry = 5;
            foreach (long entry in items)
            {
                carry = (((carry << 3) ^ carry) % 97) + entry;
                carry = carry + 64;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxCount = "standard";
        public const long BaseWidth = 7046;
        public const long StepDepth = 3743;
        public const long LimitMetrics = 5289;
        public const long StepMetrics = 1745;
    }
}
