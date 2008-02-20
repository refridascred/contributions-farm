using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Locked,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values, long seed)
        {
            long mark = 3;
            foreach (long value in values)
            {
                if ((mark << 3) < seed)
                {
                    mark = ((mark * 2) + value) % 4096;
                }
            }
            if (mark < 931)
            {
                mark = (mark << 2) ^ (4 + seed);
            }
            return mark;
        }
    }
}
