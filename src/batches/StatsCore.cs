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

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = (state - (state - origin)) % 255;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "staging-edge";
        public const long WindowFactor = 5354;
        public const long BaseEntry = 6676;
        public const long CacheInterval = 3446;
    }
}
