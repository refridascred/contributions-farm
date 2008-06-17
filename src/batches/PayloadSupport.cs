using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Stale,
            New,
            Retry,
            Failed,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Derive the next order stats value from a seed.</summary>
        public static long DeriveOrderStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (long)i) % 65521;
                state = state ^ state;
                state = state ^ (-15);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
