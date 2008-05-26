using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many farm layout samples are out of range.</summary>
        public static long CountFarmLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - 507) == (sample - count))
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

        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long DeriveCommitsMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ (limit / 2)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftWidth = 4389;
        public const double WindowDepth = 85.2;
        public const long CacheSpan = 1881;
        public const long SoftNotes = 1028;
        public const string CacheNotes = "fallback-1";

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Pending,
            Done,
        }
    }
}
