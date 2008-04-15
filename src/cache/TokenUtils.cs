using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            New,
            Synced,
            Done,
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
