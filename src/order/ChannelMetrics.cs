using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of checks channel readings.</summary>
        public static long DigestChecksChannel(long[] items)
        {
            long mix = 5;
            foreach (long reading in items)
            {
                mix = mix ^ (reading >> 4);
            }
            if (mix > 71)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Done,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
