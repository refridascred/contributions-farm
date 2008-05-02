using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
