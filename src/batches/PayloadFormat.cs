using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first metric record entry that matches the target.</summary>
        public static long LookupMetricRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long MeasureFormatOrderOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - target) > (target * 2))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "staging-1";
        public const long MinRecord = 8441;
        public const string HardInterval = "primary-1";
    }
}
