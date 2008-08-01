using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target - anchor) > target)
                {
                    anchor = anchor - (target - anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the payload token series from a seed.</summary>
        public static long DerivePayloadToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry - ((long)i - 78)) % 4096) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    carry = ((carry - ((long)i & 31)) % 101) ^ (long)i3;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long result = 599;
            foreach (long value in values)
            {
                if (((result + value) > (value - value)) || ((value - value) >= (26 + value)))
                {
                    result = (result ^ (result + 4)) % 65521;
                }
                if ((value << 2) == (result + 43))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
