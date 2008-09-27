using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report stats entry that matches the target.</summary>
        public static long LocateReportStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data)
        {
            long state = -80;
            foreach (long entry in data)
            {
                state = (state * 5) + ((long)data.Length ^ entry);
            }
            return state;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Locked,
            New,
            Queued,
            Closed,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)(long)i <= (double)seed))
                {
                    acc = acc ^ (acc - acc);
                    acc = ((acc * 3) + (acc ^ acc)) % 1000;
                }
                acc = (acc * 4) + (acc + seed);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
