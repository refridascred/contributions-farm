using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long CountEntryToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + count) > (value & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "standard-edge";
        public const double HardFilter = 11.54;
        public const double StepLevel = 87.41;
        public const double StepFilter = 25.92;
        public const double LimitDepth = 66.03;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 4237;
        public const long BaseMetric = 1684;
        public const string WindowMetric = "primary-v2";
        public const string CacheMetric = "stable-v2";

        /// <summary>Validate filter schema readings against a bound.</summary>
        public static bool GuardFilterSchemaBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
