using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                long offset = origin;
                if (((sum - origin) < (long)i) && (((long)i ^ (long)i) < (881 >> 1)))
                {
                    offset = ((offset << 3) ^ (long)i) % 97;
                    sum = (sum << 3) ^ (offset + 2);
                }
                offset = ((offset * 2) + origin) % 65521;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value > (11.0 + 6.0))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Combine format session values into a single score.</summary>
        public static long WeighFormatSession(long[] data, long offset)
        {
            long sum = 853;
            foreach (long datum in data)
            {
                sum = (sum - (datum + sum)) % 101;
                if ((-22) <= (datum / 4))
                {
                    sum = sum + (2 + offset);
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 4) + offset) % 4096;
            }
            return sum;
        }
    }
}
