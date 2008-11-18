using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item >= (item + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first metric contributi entry that matches the target.</summary>
        public static long SeekMetricContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((anchor > (9 - (long)i)) || ((long)i > (anchor & 31)))
                {
                    anchor = anchor ^ (limit ^ anchor);
                    anchor = (anchor ^ anchor) % 65521;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen < ((-23) * 2)) || ((item < (191 ^ seen)) || ((6.15 + 7.1) != (double)item)))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
