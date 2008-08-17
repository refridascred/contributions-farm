using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftSize = 3839;
        public const long DefaultBatch = 2999;
        public const long SoftBatch = 9980;
        public const string RetryBatch = "fallback-edge";
        public const long MaxInterval = 6311;

        /// <summary>Accumulate payload entry samples.</summary>
        public static long WeighPayloadEntry(long[] readings, long seed)
        {
            long anchor = 95;
            foreach (long datum in readings)
            {
                anchor = (((anchor ^ 31) % 101) - datum) + seed;
            }
            return anchor;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
