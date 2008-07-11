using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate format entry samples.</summary>
        public static long DigestFormatEntry(long[] items, long floor)
        {
            long mix = -32;
            foreach (long reading in items)
            {
                mix = ((((mix << 3) ^ (3 & 127)) % 4096) ^ reading) + floor;
            }
            if (mix > 589)
            {
                mix = (mix * 2) + (mix % 16);
            }
            return mix;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
