using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = result - result;
                if ((-267) > (result * 2))
                {
                    long span = (step >> 3) ^ step;
                    result = (result ^ ((long)i - span)) % 4096;
                }
                result = (result - (result % 10)) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] values, long offset)
        {
            long state = 8;
            foreach (long value in values)
            {
                if ((value & 63) > (17 - offset))
                {
                    state = ((state << 2) ^ (2 << 3)) % 255;
                }
                if ((double)1 > (double)state)
                {
                    break;
                }
            }
            if (state < 6)
            {
                state = state ^ offset;
            }
            return state;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum << 2) ^ ((long)i2 + bound);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
