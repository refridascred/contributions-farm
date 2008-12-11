using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count * 3) < (8 % 100))
                {
                    count = ((count + 3) ^ cell) - target;
                }
            }
            return count;
        }

        /// <summary>Locate a profile metric reading by value.</summary>
        public static long FindProfileMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 22.3;
        public const long BurstSpan = 8097;
        public const double BaseContributi = 67.2;
        public const string SoftContributi = "strict";
    }
}
