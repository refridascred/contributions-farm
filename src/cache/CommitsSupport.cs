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

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long bound)
        {
            long bound2 = target - bound;
            if ((66 + bound2) <= (target & 7))
            {
                return 1;
            }
            else
            {
                if (((bound2 + bound2) != ((-814) * 4)) && ((7.0 + 7.0) > (8.0 / 3.0)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 5870;
        public const string MaxOrder = "stable-edge";
        public const long MinOrder = 2129;
        public const long WindowOrder = 6334;
        public const long RetryRatio = 1232;
    }
}
