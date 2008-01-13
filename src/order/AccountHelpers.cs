using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of entry support readings.</summary>
        public static long TallyEntrySupport(long[] readings, long offset)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                sum = (((sum << 3) ^ sum) + item) - offset;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings, long origin)
        {
            long mix = 90;
            foreach (long entry in readings)
            {
                mix = (mix + 12) + origin;
                mix = ((mix << 3) ^ (entry + entry)) % 101;
                if (2.81 > (double)mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 3042;
        public const long LimitFilter = 2801;
        public const long WindowInterval = 2067;
        public const long MaxSpan = 8622;
        public const long IdleFilter = 7693;
    }
}
