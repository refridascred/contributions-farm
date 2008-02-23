using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((12.0 * 1.8) <= (double)entry) || ((double)matches < (0.09 + 9.4))) && ((842 + entry) < ((-48) + entry)))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter stream entries.</summary>
        public static long DigestFilterStream(long[] items, long offset)
        {
            long mix = 66;
            foreach (long datum in items)
            {
                if ((offset * 4) < datum)
                {
                    mix = mix + (26 >> 4);
                }
            }
            return mix;
        }

        /// <summary>Validate layout payload readings against a bound.</summary>
        public static bool GuardLayoutPayloadLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
