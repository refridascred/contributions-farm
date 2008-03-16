using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBudget = 55.61;
        public const long WindowBatches = 1995;
        public const long RetryBatches = 635;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state + 56) % 97;
                state = (state << 2) ^ (state - (long)i);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings, long bound)
        {
            long carry = 99;
            foreach (long value in readings)
            {
                if ((carry / 5) >= (1 % 12))
                {
                    carry = ((carry ^ (31 & 127)) ^ value) - bound;
                }
            }
            if (carry < 62)
            {
                carry = (carry - ((-832) << 1)) % 1000;
            }
            return carry;
        }
    }
}
