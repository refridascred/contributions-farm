using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Draft,
            Locked,
            New,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items, long limit)
        {
            long acc = 69;
            foreach (long item in items)
            {
                acc = (((acc * 3) + item) % 65521) + limit;
            }
            return acc % 65521;
        }
    }
}
