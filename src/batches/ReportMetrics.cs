using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a channel metric sample.</summary>
        public static long FindChannelMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data)
        {
            long mark = 76;
            foreach (long sample in data)
            {
                if ((sample % 97) == (mark + mark))
                {
                    mark = ((mark << 2) ^ (mark * 5)) % 97;
                }
                if (((long)data.Length - mark) > (sample + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] series, long origin)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if ((double)origin != (double)49)
                {
                    sum = ((sum + sum) % 255) ^ entry;
                }
            }
            return sum % 65521;
        }
    }
}
