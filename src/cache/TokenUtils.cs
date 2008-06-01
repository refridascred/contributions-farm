using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = 253;
            foreach (long entry in items)
            {
                carry = carry - carry;
                if (((12 ^ 256) > entry) || ((carry & 7) > (carry - carry)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry + (entry % 60)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series, long offset)
        {
            long anchor = -43;
            foreach (long cell in series)
            {
                anchor = anchor + (offset + anchor);
                anchor = (anchor + offset) % 65521;
                if (((cell + anchor) != (offset / 7)) || ((double)offset == (9.09 * 7.66)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
