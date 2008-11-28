using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Queued,
            Done,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long seed)
        {
            long carry = 9;
            foreach (long value in values)
            {
                if ((2 + carry) > value)
                {
                    carry = (carry << 2) ^ (value >> 4);
                }
                if (!((3.7 + 11.0) > (double)seed))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Stale,
            Dropped,
            Idle,
        }
    }
}
