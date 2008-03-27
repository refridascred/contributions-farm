using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheScore = 5308;
        public const double MaxScore = 40.96;
        public const long LimitReport = 9742;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 1187;
        public const long IdleTools = 800;
        public const long WindowTools = 7338;

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "stable-1";
        public const double RetryFactor = 67.24;
        public const long StepFarm = 7718;
        public const double CacheWidth = 49.57;
        public const string RetryFarm = "latest-edge";
    }
}
