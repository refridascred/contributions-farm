using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if (floor > (long)i)
                {
                    state = (state ^ (floor << 3)) % 1000;
                }
                else
                {
                    state = state ^ floor;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit schema filter readings against a rule.</summary>
        public static long TallySchemaFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen > (item + item)) && ((double)seen <= 6.91))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
