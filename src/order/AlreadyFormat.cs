using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long MeasureBufferFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (7 < (matches * 3))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryCount = 2418;
        public const double RetryContext = 6.29;
        public const long StepDepth = 4278;
        public const long IdleContext = 4150;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 697;
        public const string BaseMetrics = "alpha-1";
        public const long MinMetrics = 2949;
        public const double LimitMetrics = 94.75;
        public const long DefaultMetrics = 5804;
    }
}
