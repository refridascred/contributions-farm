using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= (92 + seen))
                {
                    seen = ((seen + 2) + cell) + seed;
                }
            }
            return seen;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (((state * 5) + target) % 97) ^ (long)i2;
                    state = (state ^ (long)i) % 101;
                }
                if (((long)i == (state % 64)) || ((state / 5) <= state))
                {
                    state = (state * 3) + target;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
