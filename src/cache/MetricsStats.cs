using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 6285;
        public const string BurstCommits = "latest-1";
        public const string BatchInterval = "legacy-edge";
        public const long WindowCommits = 4385;

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitInterval = 40.92;
        public const long IdleRatio = 2458;
        public const long RetryScore = 5768;

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry support readings against a bound.</summary>
        public static bool GuardEntrySupportBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every notes cache entry stays within the limit.</summary>
        public static bool CheckNotesCacheRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
