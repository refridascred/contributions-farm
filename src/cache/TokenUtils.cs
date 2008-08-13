using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command filter entries.</summary>
        public static long CombineCommandFilter(long[] samples, long step)
        {
            long mark = 45;
            foreach (long entry in samples)
            {
                if ((mark < (step << 2)) && ((entry >> 1) == (step << 1)))
                {
                    mark = ((mark * 2) + (step + step)) % 97;
                }
                else
                {
                    mark = (mark - (mark >> 2)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the queue entry entries that pass the check.</summary>
        public static long AuditQueueEntryOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum >> 1) >= (origin >> 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Locked,
            Failed,
            Pending,
        }
    }
}
