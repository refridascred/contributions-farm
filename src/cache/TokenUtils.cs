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

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepLevel = 93.55;
        public const string StepStats = "fallback";
        public const double SoftStats = 40.48;
        public const double DefaultStats = 5.22;
        public const long CacheStats = 3585;
    }
}
