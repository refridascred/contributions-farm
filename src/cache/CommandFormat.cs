using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Closed,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((7.79 + 3.13) < (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
