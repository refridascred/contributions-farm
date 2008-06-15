using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1629;
        public const long WindowInterval = 6522;
        public const long LimitStream = 3052;
        public const long DefaultRatio = 8042;

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels, long seed)
        {
            long carry = 626;
            foreach (long item in levels)
            {
                if (seed <= (carry + 15))
                {
                    carry = ((carry ^ (carry - seed)) % 97) ^ item;
                }
            }
            if (carry < 144)
            {
                carry = (carry ^ (seed + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Draft,
            Active,
        }
    }
}
