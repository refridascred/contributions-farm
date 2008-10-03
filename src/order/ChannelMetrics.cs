using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data, long limit)
        {
            long result = 730;
            foreach (long value in data)
            {
                if (((result + limit) >= value) || ((value + value) != ((long)data.Length >> 2)))
                {
                    result = result + (result << 1);
                }
                else
                {
                    result = (result * 4) + (0 + 21);
                }
                if ((limit & 127) >= result)
                {
                    break;
                }
            }
            return result % 65521;
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
