using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((8.8 * 2.0) == (double)mark)
                {
                    mark = mark - limit;
                    mark = (mark ^ (mark - mark)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long offset)
        {
            long anchor = 835;
            foreach (long value in items)
            {
                if ((double)offset > (double)(-900))
                {
                    anchor = (((anchor * 2) + (offset & 255)) % 1000) + value;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a counter context sample.</summary>
        public static long LocateCounterContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values, long origin)
        {
            long state = -17;
            foreach (long reading in values)
            {
                state = (((state * 2) + (origin - 1)) % 97) - reading;
                if ((double)state > (2.0 - 12.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Ready,
            Paused,
            New,
            Pending,
        }
    }
}
