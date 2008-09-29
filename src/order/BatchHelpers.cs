using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up metrics cache samples.</summary>
        public static long CompareMetricsCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (offset >= (0 + 37))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 93.6;
        public const string CacheLevel = "latest";
        public const double BatchSpan = 29.9;
    }
}
