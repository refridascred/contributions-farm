using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Pending,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of filter command readings.</summary>
        public static long TallyFilterCommand(long[] readings)
        {
            long carry = -142;
            foreach (long entry in readings)
            {
                carry = ((carry << 3) ^ (carry - 5)) % 1000;
                if (!((-9) < (entry - entry)))
                {
                    carry = ((carry * 2) + (entry - 866)) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (carry ^ entry)) % 65521;
                }
            }
            if (carry > 1)
            {
                carry = (carry + (carry ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Retry,
            New,
            Stale,
        }
    }
}
