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

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 7603;
        public const string HardTimeout = "standard-1";
        public const long LimitCounter = 2119;
    }
}
