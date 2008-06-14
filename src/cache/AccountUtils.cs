using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry * 2) + 998) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    carry = ((carry - carry) % 65521) + (long)i3;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] levels, long step)
        {
            long state = 295;
            foreach (long datum in levels)
            {
                if (((76 >> 4) < state) || ((3 ^ datum) != (26 % 16)))
                {
                    state = ((state + 7) % 4096) - step;
                }
            }
            return state;
        }
    }
}
