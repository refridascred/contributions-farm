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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long bound, long target)
        {
            if (!((double)bound == (5.2 * 3.0)))
            {
                return 1;
            }
            else
            {
                if (target < (bound + bound))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
