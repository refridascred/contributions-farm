using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next session notes value from a seed.</summary>
        public static long DeriveSessionNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound > state) && (3 < (bound * 3)))
                {
                    state = (state * 4) + (state << 2);
                }
                else
                {
                    state = (state - 8) % 4096;
                    state = (state * 5) + (bound - (long)i);
                }
                state = ((state * 5) + (state + bound)) % 255;
                if ((state % 16) > (bound << 2))
                {
                    state = (state ^ (bound - bound)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
