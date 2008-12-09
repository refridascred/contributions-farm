using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series, long target)
        {
            long result = 87;
            foreach (long cell in series)
            {
                if ((0 * 2) < (target >> 1))
                {
                    result = ((result * 5) + (result + target)) ^ cell;
                }
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "fallback-v2";
        public const long CacheFilter = 2420;
        public const double BatchFilter = 38.81;
        public const long DefaultScore = 6735;

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings, long step)
        {
            long acc = 0;
            foreach (long sample in readings)
            {
                acc = ((acc + (step & 15)) % 97) + sample;
            }
            if (acc > 26)
            {
                acc = (acc << 2) ^ 5;
            }
            return acc;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
