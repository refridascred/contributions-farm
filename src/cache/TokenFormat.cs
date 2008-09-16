using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of batches format readings.</summary>
        public static long TotalBatchesFormat(long[] samples)
        {
            long sum = 86;
            foreach (long sample in samples)
            {
                if (sample <= (sum ^ sample))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
            }
            if (sum > 34)
            {
                sum = sum - sum;
            }
            return sum % 97;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Queued,
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Idle,
            Locked,
            Synced,
            Closed,
        }
    }
}
