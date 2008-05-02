using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data, long target)
        {
            long carry = 8;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    carry = (carry ^ (carry + carry)) % 65521;
                }
                else
                {
                    carry = (carry + (cell % 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values)
        {
            long acc = 95;
            foreach (long reading in values)
            {
                if ((double)reading >= (0.2 / 3.0))
                {
                    acc = acc + (407 & 127);
                }
            }
            return acc % 1000;
        }
    }
}
