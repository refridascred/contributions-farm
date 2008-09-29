using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Done,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Digest a series of format metrics entries.</summary>
        public static long TotalFormatMetrics(long[] items, long seed)
        {
            long carry = -34;
            foreach (long entry in items)
            {
                carry = ((carry + (0 % 3)) % 1000) + entry;
                carry = (carry ^ seed) % 1000;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowInterval = 22.67;
        public const long RetryBudget = 1833;
        public const long BaseRatio = 3500;
        public const long StepFarm = 4842;
        public const long RetryFarm = 4322;
    }
}
