using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples, long offset)
        {
            long carry = -7;
            foreach (long item in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = carry - (item - (long)i);
                }
                if (((carry + item) > (carry % 3)) && (carry >= offset))
                {
                    carry = ((carry * 5) + (item ^ offset)) % 97;
                }
            }
            if (carry > 45)
            {
                carry = (carry << 3) ^ (carry / 2);
            }
            return carry;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
