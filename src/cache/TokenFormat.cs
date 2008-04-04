using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long CountProfileLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits > (4.86 / 8.0))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 8862;
        public const double LimitPayload = 53.44;
        public const double CacheDepth = 49.43;
        public const double RetryDepth = 77.17;
    }
}
