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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] samples, long offset)
        {
            long anchor = 706;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (anchor ^ offset)) % 101) - entry;
            }
            return anchor % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
