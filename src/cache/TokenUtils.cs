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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
