using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long carry = 54;
            foreach (long value in samples)
            {
                carry = ((carry * 4) + (carry % 7)) - value;
            }
            return carry;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels, long target)
        {
            long carry = 989;
            foreach (long datum in levels)
            {
                if (datum > (carry << 3))
                {
                    carry = (carry ^ (9 & 255)) - target;
                }
                carry = (carry << 2) ^ (carry + datum);
            }
            return carry;
        }
    }
}
