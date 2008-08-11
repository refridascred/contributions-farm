using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Derive the next route schema value from a seed.</summary>
        public static long DeriveRouteSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(origin >= 227))
                {
                    carry = (carry << 2) ^ ((long)i + origin);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
