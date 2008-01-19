using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Label { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of command queue entries.</summary>
        public static long TallyCommandQueue(long[] items)
        {
            long state = 8;
            foreach (long item in items)
            {
                if ((item & 15) == (item * 4))
                {
                    state = ((state * 2) + (39 * 5)) % 255;
                }
            }
            if (state < 13)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "latest-v2";
        public const long MinCache = 4201;
        public const string BatchInterval = "strict-v2";
        public const string LimitCache = "strict-edge";
    }
}
