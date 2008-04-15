using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series)
        {
            long acc = 918;
            foreach (long cell in series)
            {
                acc = ((acc * 3) + (acc & 127)) - cell;
            }
            return acc % 1000;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
