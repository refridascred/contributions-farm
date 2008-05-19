using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Queued,
            Ready,
            Synced,
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
