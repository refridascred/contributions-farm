using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "stable-v2";
        public const long RetryCount = 6286;
        public const string BurstMetric = "primary-1";
        public const string SoftDepth = "fallback-v2";
        public const long DefaultMetric = 1297;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((7 * 5) <= (count + value))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long bound2)
        {
            long offset = bound - bound2;
            if ((double)bound < 16.0)
            {
                return 3;
            }
            else
            {
                if (!((bound2 + bound) < (offset + bound2)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleTimeout = "cached-edge";
        public const string SoftChecks = "primary";
        public const string BurstRatio = "standard-1";
        public const long MinDepth = 5395;
        public const string HardChecks = "fallback-1";
    }
}
