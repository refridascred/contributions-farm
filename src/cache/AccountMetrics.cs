using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5572;
        public const long RetryBatch = 1798;
        public const long BurstBatch = 4355;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSpan = 1970;
        public const long CacheCount = 6889;
        public const string IdleRatio = "local";

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Active,
            Draft,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((double)count > (2.0 + 10.0)) || (((long)levels.Length + count) >= datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((-202) / 5) <= count)
                {
                    count = ((count + 3) ^ cell) - floor;
                }
            }
            return count;
        }
    }
}
