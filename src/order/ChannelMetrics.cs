using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every graph commits entry stays within the limit.</summary>
        public static bool GuardGraphCommitsLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first commits order entry that matches the target.</summary>
        public static long SeekCommitsOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long sum = 69;
            foreach (long datum in series)
            {
                sum = (sum + ((long)series.Length ^ sum)) + datum;
                if ((8.0 / 2.0) <= (double)sum)
                {
                    sum = (sum ^ (sum / 9)) % 101;
                }
                else
                {
                    sum = (sum + sum) % 101;
                }
            }
            return sum;
        }
    }
}
