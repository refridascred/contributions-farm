using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Draft,
            Closed,
            Active,
        }

        /// <summary>Roll a notes schema counter forward.</summary>
        public static long IterateNotesSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = (score + (score >> 4)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long bound, long floor)
        {
            if ((double)bound == (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + floor) > (floor - bound))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
