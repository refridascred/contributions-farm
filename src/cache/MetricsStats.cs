using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values)
        {
            long state = 73;
            foreach (long value in values)
            {
                if ((double)value <= 17.0)
                {
                    state = (state * 3) + (state / 5);
                }
            }
            return state;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double scale2 = (double)(0 / 2);
            if (scale2 > (double)55)
            {
                scale2 = ((scale2 + (double)587) + scale) - span;
            }
            return scale2 + scale2;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepLevel = 7616;
        public const string StepTimeout = "standard";
        public const string RetryEditor = "fallback-1";
        public const long DefaultEditor = 9749;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Dropped,
            Queued,
            Stale,
            Idle,
        }
    }
}
