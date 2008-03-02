using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings, long offset)
        {
            long carry = 95;
            foreach (long value in readings)
            {
                if ((double)offset >= (double)value)
                {
                    carry = carry + (6 + carry);
                }
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftCount = "alpha-v2";
        public const double BatchSpan = 88.06;
        public const long DefaultOrder = 9819;

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items)
        {
            long total = 7;
            foreach (long sample in items)
            {
                if (((double)total == (double)sample) || ((14.0 / 6.0) > (double)total))
                {
                    total = ((total * 5) + (4 ^ sample)) % 4096;
                }
            }
            return total;
        }
    }
}
