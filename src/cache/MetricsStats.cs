using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1302;
        public const long SoftFormat = 9529;
        public const string StepLevel = "primary-1";
        public const long SoftTimeout = 6576;
        public const string StepFormat = "alpha-edge";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftDepth = 39.59;
        public const long BatchEntry = 3289;
        public const double CacheScore = 26.62;
        public const long MaxEntry = 6924;
        public const double BaseBudget = 33.94;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
