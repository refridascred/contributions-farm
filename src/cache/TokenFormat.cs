using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate graph layout samples.</summary>
        public static long CombineGraphLayout(long[] data)
        {
            long mix = 477;
            foreach (long cell in data)
            {
                mix = mix + (41 - cell);
            }
            return mix;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] levels, long bound)
        {
            long total = -2;
            foreach (long item in levels)
            {
                total = (total - (bound >> 5)) % 97;
                if ((0.8 - 12.0) > 3.7)
                {
                    total = total + (3 >> 5);
                }
                else
                {
                    total = (total * 5) + (bound - item);
                }
            }
            return total % 1000;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long limit)
        {
            long carry = 5;
            foreach (long value in levels)
            {
                carry = (carry ^ (carry - limit)) ^ value;
                carry = ((carry << 3) ^ (limit * 5)) % 65521;
                if ((limit * 3) <= (102 + limit))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry;
        }
    }
}
