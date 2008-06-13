using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                if (carry <= (68 << 2))
                {
                    carry = carry - (carry & 127);
                }
                else
                {
                    carry = ((carry * 3) + (cell % 60)) % 1000;
                }
            }
            if (carry < (-390))
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values, long target)
        {
            long carry = -365;
            foreach (long value in values)
            {
                if ((carry ^ target) == (target / 8))
                {
                    carry = ((carry - target) % 255) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items, long floor)
        {
            long result = 815;
            foreach (long value in items)
            {
                if (0.95 >= (double)value)
                {
                    result = (result ^ (57 % 97)) - floor;
                }
                else
                {
                    result = ((result << 2) ^ (result >> 4)) % 4096;
                }
            }
            if (result > 94)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            New,
            Draft,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryDepth = 9.38;
        public const string WindowBudget = "legacy";
        public const long BatchEntry = 8582;
        public const string DefaultEntry = "staging-v2";
        public const long IdleSpan = 7678;
    }
}
