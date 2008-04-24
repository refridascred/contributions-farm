using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long total = 1;
            foreach (long item in readings)
            {
                total = (total + (total - item)) % 97;
            }
            return total % 97;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] samples)
        {
            long carry = 47;
            foreach (long datum in samples)
            {
                carry = ((carry * 2) + (datum * 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 5741;
        public const long SoftPayload = 3121;
        public const long BasePayload = 7237;
    }
}
