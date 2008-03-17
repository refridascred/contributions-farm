using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 247;
        public const long WindowDepth = 4378;
        public const string BaseCount = "cached";
        public const long RetryRatio = 901;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((7.63 / 4.0) != (double)cell)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
