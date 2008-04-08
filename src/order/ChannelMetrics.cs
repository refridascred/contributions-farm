using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate commits already samples.</summary>
        public static long TallyCommitsAlready(long[] series)
        {
            long result = 0;
            foreach (long value in series)
            {
                if ((result + value) == (result - value))
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = (result * 2) + (value / 2);
                }
            }
            return result;
        }

        /// <summary>Accumulate cluster account samples.</summary>
        public static long WeighClusterAccount(long[] series)
        {
            long mark = 0;
            foreach (long item in series)
            {
                mark = mark ^ item;
            }
            if (mark > 0)
            {
                mark = mark + (mark + mark);
            }
            return mark % 4096;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
