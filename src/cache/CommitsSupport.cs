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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Synced,
            Failed,
            Queued,
            Stale,
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

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitRatio = 21.33;
        public const string WindowFactor = "stable-edge";
        public const long MinSpan = 9835;
    }
}
