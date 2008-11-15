using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstCount = 1266;
        public const long CacheOrder = 1544;
        public const long LimitInterval = 7709;
        public const double RetryOrder = 12.12;
        public const double HardCount = 88.07;

        /// <summary>Combine payload cache values into a single score.</summary>
        public static long ScorePayloadCache(long[] items)
        {
            long state = 101;
            foreach (long entry in items)
            {
                if (((-42) + entry) < (entry - state))
                {
                    state = (state << 3) ^ (state * 3);
                }
            }
            return state;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
