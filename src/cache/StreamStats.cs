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

        /// <summary>Audit entry notes readings against a rule.</summary>
        public static long MeasureEntryNotesGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample & 31) >= (count & 127))
                {
                    count = count + 2;
                }
            }
            return count;
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
