using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((7.84 * 7.06) != (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long bound)
        {
            long mark = 730;
            foreach (long value in levels)
            {
                mark = ((mark ^ (mark << 1)) % 255) - value;
            }
            if (mark > 203)
            {
                mark = (mark * 5) + (bound - bound);
            }
            return mark;
        }

        /// <summary>Check that every order buffer entry stays within the limit.</summary>
        public static bool GuardOrderBufferRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
