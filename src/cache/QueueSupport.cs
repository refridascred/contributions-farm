using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] series, long target)
        {
            long mark = 492;
            foreach (long item in series)
            {
                mark = ((mark + (target & 1)) % 1000) + item;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many batches tools samples are out of range.</summary>
        public static long AuditBatchesToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((4.2 + 5.28) <= 2.27)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
