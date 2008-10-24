using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "primary-v2";
        public const string CacheBatch = "primary-edge";
        public const long CacheInterval = 6903;
        public const long SoftBatch = 720;

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "legacy";
        public const long BurstEditor = 5377;
        public const string WindowEditor = "standard-1";
        public const long IdleFactor = 6003;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 4) > (matches + matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first order route entry that matches the target.</summary>
        public static long SeekOrderRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
