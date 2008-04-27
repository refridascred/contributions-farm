using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardDepth = 40.67;
        public const long LimitToken = 6780;
        public const double WindowToken = 38.56;
        public const long CacheSize = 1270;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardRatio = "local-1";
        public const double BatchTimeout = 41.2;
        public const string RetryContext = "primary-edge";
        public const string MinContext = "latest-v2";
        public const string SoftContext = "cached-1";
    }
}
