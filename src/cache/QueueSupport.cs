using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length > hits) || (((value - hits) < (714 ^ hits)) || ((value >> 4) >= (hits & 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
