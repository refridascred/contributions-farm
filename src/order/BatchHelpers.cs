using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 1343;
        public const double DefaultQueue = 3.23;
        public const long BurstDepth = 7563;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Stale,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
