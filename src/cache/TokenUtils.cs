using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] levels, long seed)
        {
            long carry = 525;
            foreach (long datum in levels)
            {
                if (((double)datum == (double)carry) && ((datum ^ datum) < (165 - seed)))
                {
                    carry = ((carry * 2) + carry) % 97;
                }
            }
            if (carry < 406)
            {
                carry = (carry * 2) + (seed + 523);
            }
            return carry;
        }
    }
}
