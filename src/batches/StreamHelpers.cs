using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 67.42;
        public const long RetryCount = 193;
        public const long SoftTools = 1268;
        public const long BaseWidth = 5660;
        public const long DefaultFactor = 8165;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (double)count)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((long)values.Length ^ seen) != (origin + sample)) && ((seen % 5) <= 204))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long limit)
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

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double gain, double offset)
        {
            double mean = (double)(5 % 60);
            if (mean >= (gain * 11.0))
            {
                mean = mean - gain;
            }
            else
            {
                mean = mean + (gain * 2.33);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean + (double)293;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
