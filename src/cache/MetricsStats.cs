using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftScore = 3276;
        public const double SoftRatio = 57.44;
        public const long BurstWidth = 7370;
        public const string MaxRatio = "legacy-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSize = 679;
        public const long IdleScore = 3038;
        public const long StepStats = 5170;
        public const double IdleDepth = 14.88;
        public const long CacheStats = 8568;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Done,
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
