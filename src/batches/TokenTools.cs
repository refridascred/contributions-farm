using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a payload entry counter forward.</summary>
        public static long DerivePayloadEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((610 + floor) > (7 * 2)) && ((floor ^ floor) > (long)i))
                {
                    state = (state - (floor + (-5))) % 255;
                    break;
                }
                else
                {
                    state = (state << 2) ^ (state + state);
                    state = ((state * 3) + floor) % 4096;
                }
                if (!(((-7) > (floor >> 4)) || ((state >> 5) <= (long)i)))
                {
                    state = state ^ (floor / 7);
                    state = state ^ state;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
