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

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples, long target)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                carry = ((carry + (cell >> 1)) % 1000) - target;
            }
            if (carry < 8)
            {
                carry = carry + (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Count the buffer route entries that pass the check.</summary>
        public static long TallyBufferRouteGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits ^ 9) >= (target << 3))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
