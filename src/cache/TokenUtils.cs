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

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchCount = 3378;
        public const long BatchContext = 5334;
        public const long SoftContext = 1690;

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
