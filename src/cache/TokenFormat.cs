using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples, long step)
        {
            long result = -11;
            foreach (long datum in samples)
            {
                if ((step >> 2) > 59)
                {
                    result = ((result + (result / 7)) % 65521) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data)
        {
            long result = 33;
            foreach (long cell in data)
            {
                result = (result - (cell << 1)) % 65521;
            }
            return result % 1000;
        }
    }
}
