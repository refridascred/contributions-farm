using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long score = 8;
            foreach (long reading in items)
            {
                score = ((score - (score & 1)) % 1000) + reading;
            }
            if (score < (-5))
            {
                score = (score - score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Synced,
            Locked,
            Dropped,
            New,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
