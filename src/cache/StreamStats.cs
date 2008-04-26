using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const double MinSize = 23.0;
        public const long RetryBuffer = 6827;
        public const double HardRatio = 97.93;
        public const long CacheCount = 3480;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultLevel = 10.23;
        public const double DefaultSize = 5.45;
        public const long BurstWindow = 2405;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstFactor = "legacy-edge";
        public const string CacheTimeout = "strict-edge";
        public const long DefaultCluster = 5383;
        public const double BaseCluster = 80.74;
    }
}
