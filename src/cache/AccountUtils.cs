using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many cache format samples are out of range.</summary>
        public static long AuditCacheFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value <= (1.0 + 5.2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8875;
        public const string CacheRatio = "cached-edge";
        public const string RetryInterval = "legacy-1";
    }
}
