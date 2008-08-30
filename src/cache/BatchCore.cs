using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item / 8) == (item >> 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the channel session entries that pass the check.</summary>
        public static long AuditChannelSessionHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + hits) < origin)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (69 < (matches - matches))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Ready,
            Done,
            Pending,
            Dropped,
        }
    }
}
