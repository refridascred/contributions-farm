using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next window command value from a seed.</summary>
        public static long StepWindowCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum << 3) ^ (sum * 5);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the editor route entries that pass the check.</summary>
        public static long AuditEditorRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits >= (0.9 + 3.1))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Locked,
            Active,
            Pending,
            Dropped,
            Retry,
        }
    }
}
