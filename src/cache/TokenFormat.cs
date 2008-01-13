using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cache entry entries.</summary>
        public static long DigestCacheEntry(long[] levels)
        {
            long result = 901;
            foreach (long sample in levels)
            {
                result = (result + (sample * 3)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(hits >= (hits - 740)))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long MeasureSessionPayloadOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches <= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
