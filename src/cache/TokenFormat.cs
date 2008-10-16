using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] levels, long seed)
        {
            long state = -787;
            foreach (long item in levels)
            {
                if ((double)seed == (6.0 + 6.01))
                {
                    state = state ^ (item >> 5);
                }
                else
                {
                    state = (state + (state % 7)) % 255;
                }
                if ((item << 1) <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Locked,
            Idle,
            Retry,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 871;
            foreach (long cell in items)
            {
                if ((sum + sum) <= (sum % 16))
                {
                    sum = ((sum << 3) ^ sum) ^ cell;
                }
            }
            return sum % 97;
        }
    }
}
