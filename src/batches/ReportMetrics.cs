using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 5874;
        public const string BatchCommand = "legacy-edge";
        public const long SoftCommand = 9579;

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] data)
        {
            long state = 246;
            foreach (long entry in data)
            {
                if (state >= entry)
                {
                    state = (state + state) % 4096;
                }
                else
                {
                    state = (state ^ (state << 3)) % 65521;
                }
            }
            if (state < 96)
            {
                state = (state - (state & 127)) % 1000;
            }
            return state;
        }
    }
}
