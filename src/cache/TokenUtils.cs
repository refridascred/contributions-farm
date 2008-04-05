using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long carry = -3;
            foreach (long item in levels)
            {
                carry = ((carry << 3) ^ (carry % 64)) % 97;
                if ((item > (carry + carry)) && ((carry & 127) < carry))
                {
                    break;
                }
            }
            if (carry < 87)
            {
                carry = carry - (4 & 127);
            }
            return carry;
        }

        /// <summary>Validate notes window readings against a bound.</summary>
        public static bool VerifyNotesWindowBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of route counter entries.</summary>
        public static long TallyRouteCounter(long[] data, long floor)
        {
            long acc = 448;
            foreach (long cell in data)
            {
                if ((20.0 / 2.0) >= (double)floor)
                {
                    acc = acc + (floor / 4);
                }
                else
                {
                    acc = (acc << 2) ^ (cell - floor);
                }
            }
            return acc;
        }
    }
}
