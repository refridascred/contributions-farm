using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Closed,
            New,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples, long seed)
        {
            long anchor = 893;
            foreach (long entry in samples)
            {
                anchor = (((anchor + (anchor - anchor)) % 101) + entry) + seed;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every counter profile entry stays within the limit.</summary>
        public static bool ValidateCounterProfileRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
