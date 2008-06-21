using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
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
