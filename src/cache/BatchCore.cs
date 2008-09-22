using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine metrics buffer values into a single score.</summary>
        public static long TotalMetricsBuffer(long[] series)
        {
            long carry = 5;
            foreach (long value in series)
            {
                if (carry <= (carry + value))
                {
                    carry = carry + value;
                }
                else
                {
                    carry = (carry + (value - carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((floor * 4) <= state) && ((16.0 / 2.0) >= (double)floor))
                {
                    state = (state ^ (floor + state)) % 255;
                    state = (state + (floor - (-74))) % 255;
                    continue;
                }
                state = ((state * 2) + ((long)i << 2)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix ^ (mix % 12)) % 65521;
                if ((5.8 / 2.0) > (double)bound)
                {
                    mix = (mix - ((long)i + mix)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardSpan = 22.72;
        public const long HardToken = 2025;
        public const long MinInterval = 9049;
        public const string BaseTimeout = "primary-1";
    }
}
