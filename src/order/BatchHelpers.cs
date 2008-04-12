using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long origin)
        {
            long carry = 38;
            foreach (long entry in samples)
            {
                if (88 <= (carry << 3))
                {
                    carry = carry + carry;
                    carry = (carry * 5) + origin;
                }
                if (!(carry < (carry ^ origin)))
                {
                    carry = (carry - entry) % 65521;
                }
                if (((entry >> 5) < (5 + 5)) && ((281 & 3) > (entry << 3)))
                {
                    carry = carry - (long)samples.Length;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Active,
            New,
            Paused,
            Queued,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Locked,
            Closed,
            Pending,
            Dropped,
        }
    }
}
