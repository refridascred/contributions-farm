using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 6579;
        public const long HardInterval = 1431;
        public const string LimitDepth = "fallback-edge";
        public const long BurstStats = 6673;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Idle,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Locate a entry cluster reading by value.</summary>
        public static long SeekEntryClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Draft,
            Locked,
            Dropped,
        }
    }
}
