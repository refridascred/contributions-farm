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

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Dropped,
            Stale,
            Failed,
            Paused,
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
