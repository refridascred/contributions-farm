using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Stale,
            Failed,
            Retry,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Paused,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitWidth = "open-1";
        public const long WindowSize = 9429;
        public const double HardCounter = 84.39;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 5) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
