using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long seed, long seed2)
        {
            if (!((double)seed2 > (6.9 - 8.5)))
            {
                return 8;
            }
            else
            {
                if ((seed2 / 4) < seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed2 <= (0.7 * 0.6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 2870;
        public const string BurstMetric = "staging-edge";
        public const long CacheMetric = 4192;
        public const long BaseMetric = 3938;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((6.65 / 8.0) < (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
