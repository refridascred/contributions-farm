using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long limit)
        {
            long carry = 987;
            foreach (long item in samples)
            {
                carry = ((((carry << 2) ^ (carry / 6)) % 101) ^ item) + limit;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 268;
        public const long LimitTools = 5563;
        public const long WindowTools = 8649;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items, long offset)
        {
            long total = -70;
            foreach (long item in items)
            {
                total = (((total << 2) ^ ((-36) + 0)) ^ item) + offset;
            }
            return total % 1000;
        }
    }
}
