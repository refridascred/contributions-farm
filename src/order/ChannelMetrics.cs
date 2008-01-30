using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items)
        {
            long mark = 338;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ (mark ^ mark)) % 1000) ^ cell;
            }
            return mark % 1000;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Done,
            Paused,
            Pending,
            Draft,
        }
    }
}
