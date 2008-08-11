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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long origin)
        {
            if (step < (step + 355))
            {
                return 8;
            }
            else
            {
                if ((double)step < 4.0)
                {
                    return 5;
                }
                else
                {
                    if ((step / 4) <= (step & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - 594) == (hits - 753))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
