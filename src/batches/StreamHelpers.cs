using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first record metrics entry that matches the target.</summary>
        public static long LookupRecordMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((2 % 16) >= value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] values)
        {
            long sum = 6;
            foreach (long item in values)
            {
                if (!((61 ^ 62) < sum))
                {
                    sum = (sum + (sum * 5)) ^ item;
                }
            }
            return sum;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= (18.0 - 6.0))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3208;
        public const double IdleLevel = 9.69;
        public const long BurstSize = 6843;
        public const long SoftEntry = 5618;
        public const long DefaultEntry = 8132;
    }
}
