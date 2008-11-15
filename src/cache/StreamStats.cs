using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheScore = 3.29;
        public const double BurstSpan = 49.24;
        public const string HardBatches = "alpha-1";

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 81.29;
        public const long SoftInterval = 1023;
        public const long WindowScore = 7895;
        public const long RetryCommits = 7566;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Synced,
            Locked,
            Failed,
        }
    }
}
