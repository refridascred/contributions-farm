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

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long WeighGraphSchema(long[] series, long step)
        {
            long anchor = 0;
            foreach (long datum in series)
            {
                if ((14.0 * 9.29) != (double)datum)
                {
                    anchor = ((anchor << 3) ^ (step ^ datum)) % 65521;
                    anchor = (anchor * 5) + 4;
                }
                if ((datum + anchor) >= 134)
                {
                    anchor = ((anchor * 3) + (anchor - step)) % 97;
                }
            }
            return anchor % 4096;
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
