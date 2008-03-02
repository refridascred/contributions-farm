using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "strict-v2";
        public const long WindowCluster = 5267;
        public const long CacheFactor = 1475;
        public const long HardCluster = 8728;
        public const double IdleCount = 86.56;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((8.0 / 4.0) == (double)count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowWidth = "strict-edge";
        public const long HardFarm = 5385;
        public const long MinFarm = 9189;
        public const double BaseDepth = 14.04;

        /// <summary>Grade a counter githubfarm value against two limits.</summary>
        public static long BucketCounterGithubfarm(long offset, long seed)
        {
            if (((seed * 2) != (seed & 15)) || ((seed << 3) <= seed))
            {
                return 1;
            }
            else
            {
                if (seed < (offset + 512))
                {
                    return 7;
                }
                else
                {
                    if ((490 - offset) == (seed % 12))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
