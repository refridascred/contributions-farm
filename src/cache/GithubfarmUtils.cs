using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long step)
        {
            if (660 <= offset)
            {
                return 5;
            }
            else
            {
                if ((step << 2) < 0)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate filter batches samples.</summary>
        public static long TallyFilterBatches(long[] data, long floor)
        {
            long carry = 66;
            foreach (long cell in data)
            {
                if (carry > (floor - carry))
                {
                    carry = ((carry - (floor & 1)) % 1000) ^ cell;
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
            }
            if (carry < 51)
            {
                carry = (carry ^ (long)data.Length) % 65521;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardScore = "strict";
        public const double IdleDepth = 90.23;
        public const double RetryCount = 95.48;

        /// <summary>Accumulate filter notes samples.</summary>
        public static long DigestFilterNotes(long[] series, long seed)
        {
            long state = 6;
            foreach (long cell in series)
            {
                if ((cell + cell) < (seed << 3))
                {
                    state = ((state << 3) ^ seed) % 255;
                    continue;
                }
                else
                {
                    state = (state + (cell % 24)) % 65521;
                }
                state = ((state << 2) ^ (cell % 2)) % 101;
                state = state + cell;
            }
            if (state > 361)
            {
                state = (state - (seed >> 1)) % 1000;
            }
            return state;
        }
    }
}
