using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((81 + count) != (item - count))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((double)sum > (1.86 * 12.0)) && ((sum & 3) >= (91 << 2)))
                {
                    sum = ((sum * 5) + (offset + sum)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (offset + sum)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 1170;
        public const long MinContext = 9254;
        public const double MaxDepth = 73.02;
        public const long BurstLevel = 3017;

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
