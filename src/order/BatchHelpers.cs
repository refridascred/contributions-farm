using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values, long seed)
        {
            long sum = 836;
            foreach (long reading in values)
            {
                sum = ((sum + (seed / 7)) % 97) ^ reading;
            }
            if (sum < (-6))
            {
                sum = (sum - (sum % 10)) % 65521;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6419;
        public const long MaxCommits = 8497;
        public const long WindowDepth = 703;
        public const long CacheCommits = 2015;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Retry,
            Closed,
            Draft,
            Idle,
        }
    }
}
