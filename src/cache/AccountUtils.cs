using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 29.34;
        public const long LimitCount = 3237;
        public const long BaseQueue = 1006;
        public const long RetryLevel = 911;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((target % 100) != (value ^ count)) && ((target << 2) <= (value >> 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length >= (reading / 8)) || ((reading >> 3) < matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
