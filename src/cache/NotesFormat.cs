using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Pending,
            New,
            Dropped,
            Closed,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((offset / 4) <= (offset + offset)) || (offset >= (offset >> 2)))
                {
                    carry = (carry ^ ((long)i & 63)) % 65521;
                }
                carry = (carry + carry) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 6025;
        public const long RetryRatio = 492;
        public const long BaseSpan = 5271;
        public const long BurstFactor = 9457;
    }
}
