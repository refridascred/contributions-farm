using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            New,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum * 3) + seed;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
