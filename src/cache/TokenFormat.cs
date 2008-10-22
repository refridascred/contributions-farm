using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate record entry samples.</summary>
        public static long FoldRecordEntry(long[] levels)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                if (((value >> 3) < (value + value)) || ((-65) < (value + anchor)))
                {
                    anchor = ((anchor * 5) + (value % 7)) % 101;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor ^ (anchor * 4);
            }
            return anchor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed ^ state) >= (seed - (-388)))
                {
                    state = (state + ((long)i ^ state)) % 4096;
                    continue;
                }
                else
                {
                    state = (state << 2) ^ 2;
                }
                state = state - (seed + state);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
