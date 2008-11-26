using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum < (hits >> 2))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }
    }
}
