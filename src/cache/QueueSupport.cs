using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((origin & 255) != (entry - hits)) && (((origin + entry) < hits) && ((double)origin < (1.2 * 19.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue filter readings.</summary>
        public static long DigestQueueFilter(long[] series, long seed)
        {
            long total = 978;
            foreach (long entry in series)
            {
                total = ((total << 2) ^ (2 + entry)) % 4096;
                if ((total + seed) == (entry - seed))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Paused,
            Closed,
        }
    }
}
