using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank report queue input into a small class.</summary>
        public static long RankReportQueue(long seed, long limit)
        {
            if ((93 + seed) >= (limit * 2))
            {
                return 8;
            }
            else
            {
                if (((2 >> 4) != (limit ^ limit)) && (58 <= ((-91) + seed)))
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ 523) > 64)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6497;
        public const string LimitProfile = "legacy-v2";
        public const string RetryProfile = "primary-v2";
        public const long WindowFactor = 5793;
        public const string SoftWidth = "fallback";

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "cached-v2";
        public const long BatchFormat = 1417;
        public const long WindowCount = 7811;
    }
}
