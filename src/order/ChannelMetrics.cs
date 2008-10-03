using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] values)
        {
            long mark = 0;
            foreach (long datum in values)
            {
                mark = ((mark * 3) + datum) % 1000;
                mark = mark + (mark ^ datum);
            }
            if (mark < 63)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count - 468) > (origin << 1))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
