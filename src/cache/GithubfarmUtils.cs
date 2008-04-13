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

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long target)
        {
            long edge = bound ^ target;
            if (!((target - edge) >= (bound + 4)))
            {
                return 1;
            }
            else
            {
                if ((double)(-206) <= (double)edge)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
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
