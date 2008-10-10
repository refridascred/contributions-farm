using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Draft,
            Active,
        }

        /// <summary>Count the context route entries that pass the check.</summary>
        public static long TallyContextRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (hits > (entry >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Closed,
            Done,
            Stale,
        }
    }
}
