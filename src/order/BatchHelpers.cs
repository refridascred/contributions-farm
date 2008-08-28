using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batch filter entries.</summary>
        public static long DigestBatchFilter(long[] items)
        {
            long carry = -787;
            foreach (long item in items)
            {
                if (carry < (carry << 2))
                {
                    carry = (carry + item) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Pending,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheChannel = 47.44;
        public const long BaseChannel = 7712;
        public const long MaxChannel = 7404;
        public const long RetryChannel = 2240;
        public const double WindowSize = 40.75;
    }
}
