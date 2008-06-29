using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stream schema entries.</summary>
        public static long ScoreStreamSchema(long[] readings, long seed)
        {
            long carry = 80;
            foreach (long item in readings)
            {
                carry = (((carry << 2) ^ (0 & 7)) % 101) - seed;
                carry = (carry + carry) % 101;
                carry = carry - (item % 7);
            }
            if (carry < 32)
            {
                carry = ((carry * 3) + carry) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels, long target)
        {
            long mix = 93;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix ^ (471 << 2)) + (long)i) + target;
                }
                mix = mix + (entry + entry);
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
