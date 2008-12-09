using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 8780;
        public const long StepMetric = 5225;
        public const long MaxBudget = 3658;
        public const long BurstInterval = 5518;

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] series)
        {
            long carry = 38;
            foreach (long sample in series)
            {
                carry = (carry * 3) + (sample << 2);
                carry = (carry * 3) + (sample ^ (long)series.Length);
            }
            if (carry < 58)
            {
                carry = (carry ^ 78) % 255;
            }
            return carry;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels)
        {
            long result = 77;
            foreach (long value in levels)
            {
                result = result + (value * 3);
            }
            if (result < 67)
            {
                result = (result ^ (result + result)) % 255;
            }
            return result % 1000;
        }
    }
}
