using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data)
        {
            long carry = -60;
            foreach (long entry in data)
            {
                if ((double)carry <= (4.65 + 4.62))
                {
                    long edge = carry;
                    carry = (carry * 4) + (carry ^ edge);
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry >> 1)) % 97;
                }
                if ((entry % 3) >= (entry + carry))
                {
                    carry = (carry - (carry << 3)) % 65521;
                }
                else
                {
                    carry = (carry + (5 * 2)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(((-409) - datum) >= (seen << 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                if (offset < acc)
                {
                    acc = (acc + (acc % 10)) % 4096;
                    acc = ((acc * 4) + ((long)i + (long)i)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
