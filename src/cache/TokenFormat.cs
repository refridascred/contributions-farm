using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen >= (sample << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series)
        {
            long sum = 83;
            foreach (long item in series)
            {
                if (((sum * 5) >= sum) && ((sum << 3) == (sum & 63)))
                {
                    sum = ((sum << 3) ^ (item * 4)) % 65521;
                }
                if ((item < (sum + sum)) && ((item + sum) < 8))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 5476;
        public const long BaseOrder = 1574;
        public const long MaxOrder = 4914;
        public const long HardCount = 6260;
    }
}
