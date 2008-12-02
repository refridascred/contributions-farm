using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long offset)
        {
            long diff = floor + offset;
            if (!((diff % 100) >= offset))
            {
                return 2;
            }
            else
            {
                if ((diff >> 5) > 375)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if ((7.64 - 7.4) == (double)sum)
                {
                    sum = (((sum << 3) ^ 622) % 255) ^ cell;
                }
            }
            if (sum > 53)
            {
                sum = (sum << 2) ^ (long)items.Length;
            }
            return sum;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (9.0 * 15.0))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
