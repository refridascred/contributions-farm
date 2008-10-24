using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mix = -489;
            foreach (long value in readings)
            {
                if ((value + mix) < value)
                {
                    mix = (mix + value) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
