using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next support metrics value from a seed.</summary>
        public static long DeriveSupportMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state * 5) + (limit * 5);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state + 393) % 4096) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
