using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Count the already order entries that pass the check.</summary>
        public static long MeasureAlreadyOrderGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen > (12.0 * 19.0))
                {
                    seen = ((seen + 2) ^ datum) - step;
                }
            }
            return seen;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Locked,
            Paused,
            Ready,
            Done,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
