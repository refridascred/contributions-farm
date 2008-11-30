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

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double bias2)
        {
            double gain = (double)(792 - 68);
            if (gain > bias2)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (bias2 - 8.0);
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
