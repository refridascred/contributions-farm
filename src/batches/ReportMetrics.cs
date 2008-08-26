using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long limit, long floor)
        {
            if (!(limit < (floor & 1)))
            {
                return 6;
            }
            else
            {
                if ((9.0 * 0.1) >= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Find the first context schema entry that matches the target.</summary>
        public static long LocateContextSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
