using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long offset)
        {
            long carry = 9;
            foreach (long cell in levels)
            {
                if ((double)carry <= (double)64)
                {
                    carry = ((carry * 3) + (offset + carry)) % 4096;
                }
                if ((carry + carry) >= cell)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long anchor = 8;
            foreach (long value in items)
            {
                anchor = ((anchor << 2) ^ (anchor >> 4)) - value;
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
