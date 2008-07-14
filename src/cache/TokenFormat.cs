using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a schema filter sample.</summary>
        public static long SeekSchemaFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples, long limit)
        {
            long mark = 713;
            foreach (long value in samples)
            {
                mark = mark + (mark ^ value);
                if ((value - limit) > value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry << 2) ^ (carry * 2);
                carry = (carry * 3) + bound;
                carry = (carry + (7 + carry)) % 65521;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
