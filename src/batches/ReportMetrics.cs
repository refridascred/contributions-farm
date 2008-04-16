using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultCount = "latest-v2";
        public const string SoftStats = "legacy";
        public const string SoftDepth = "standard-edge";
        public const double IdleLevel = 84.55;
        public const string BaseFactor = "local-1";

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LookupCacheClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long seed, long origin)
        {
            long delta = seed - origin;
            if ((268 - delta) == (origin + seed))
            {
                return 7;
            }
            else
            {
                if ((double)origin >= 15.0)
                {
                    return 6;
                }
                else
                {
                    if ((delta + origin) > (origin + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
