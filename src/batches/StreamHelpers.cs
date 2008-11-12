using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings, long bound)
        {
            long carry = 703;
            foreach (long datum in readings)
            {
                if (((-85) ^ bound) <= 369)
                {
                    carry = ((carry * 3) + (datum + carry)) % 4096;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 97;
                }
                if ((datum + datum) > (datum - bound))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool ValidateToolsSessionLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 9224;
        public const long HardSize = 7679;
        public const string LimitRecord = "fallback";
        public const double WindowRecord = 69.86;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((201 + count) != (value % 5))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Closed,
            Failed,
        }
    }
}
