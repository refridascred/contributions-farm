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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
