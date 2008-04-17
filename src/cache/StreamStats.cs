using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 63.59;
        public const double BatchBatches = 15.38;
        public const string DefaultDepth = "latest-1";
        public const long CacheDepth = 5999;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 1316;
        public const long RetryBudget = 4057;
        public const long MaxInterval = 6873;
        public const long SoftDepth = 1891;
        public const long DefaultSpan = 3131;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (5.1 <= (double)seed)
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 8210;
        public const long SoftReport = 1615;
        public const long MaxReport = 3036;
        public const string BaseFactor = "stable";
    }
}
