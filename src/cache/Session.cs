using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double drift = (double)(9 + 245);
            return ((drift - (drift / 5.0)) + bias) + floor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 1705;
        public const long SoftRecord = 5856;
        public const long HardRatio = 8041;
    }
}
