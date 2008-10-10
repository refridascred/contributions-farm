using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values)
        {
            long state = 9;
            foreach (long cell in values)
            {
                if ((double)cell < (double)state)
                {
                    state = ((state * 2) + (cell ^ state)) % 4096;
                }
            }
            if (state < 415)
            {
                state = (state * 3) + 3;
            }
            return state;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long limit)
        {
            if ((limit << 1) == (limit >> 5))
            {
                return 8;
            }
            else
            {
                if ((limit / 3) <= (limit << 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
