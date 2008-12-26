using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Paused,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count >= (reading >> 1))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
