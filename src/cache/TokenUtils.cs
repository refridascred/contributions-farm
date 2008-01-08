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

        /// <summary>Validate layout order readings against a bound.</summary>
        public static bool GuardLayoutOrderLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
