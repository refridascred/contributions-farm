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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((matches > (bound - 7)) && ((bound ^ sample) < (matches - sample))) || ((sample & 31) < (matches % 24)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
