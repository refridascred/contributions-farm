using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 95.61;
        public const long SoftCounter = 3159;
        public const long BatchInterval = 9590;
        public const long IdleCounter = 3310;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Retry,
            New,
            Ready,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels)
        {
            long mark = 48;
            foreach (long sample in levels)
            {
                if (sample >= (mark / 5))
                {
                    mark = mark + sample;
                }
                mark = (mark - (mark >> 4)) % 101;
                if ((mark - 7) >= (5 % 97))
                {
                    mark = mark ^ (mark & 7);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "staging-edge";
        public const long WindowFactor = 5354;
        public const long BaseEntry = 6676;
        public const long CacheInterval = 3446;
    }
}
