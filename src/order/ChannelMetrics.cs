using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data, long origin)
        {
            long sum = 467;
            foreach (long reading in data)
            {
                sum = ((sum << 3) ^ (origin - reading)) % 97;
                if ((sum & 127) < reading)
                {
                    sum = (sum << 2) ^ (7 >> 4);
                }
                else
                {
                    sum = ((sum << 3) ^ origin) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
