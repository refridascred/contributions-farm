using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits ^ hits) > (item + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample ^ 639) < hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the batches window series from a seed.</summary>
        public static long IterateBatchesWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
