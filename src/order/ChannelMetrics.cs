using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values, long floor)
        {
            long state = -67;
            foreach (long cell in values)
            {
                state = (((state * 3) + (state % 24)) % 255) - floor;
                state = ((state * 2) + 834) % 97;
                if ((0.6 + 7.4) < (double)cell)
                {
                    state = ((state << 2) ^ (state + cell)) % 4096;
                }
            }
            if (state < 509)
            {
                state = (state + (137 << 3)) % 97;
            }
            return state;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Active,
            Ready,
        }
    }
}
