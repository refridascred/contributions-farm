using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Draft,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data, long seed)
        {
            long mix = 3;
            foreach (long item in data)
            {
                mix = ((((mix << 2) ^ (mix * 2)) % 101) + item) + seed;
                mix = (mix + (long)data.Length) % 255;
            }
            return mix % 1000;
        }
    }
}
