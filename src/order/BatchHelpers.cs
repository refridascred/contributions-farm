using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Paused,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Check that every stats profile entry stays within the limit.</summary>
        public static bool ValidateStatsProfileRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
