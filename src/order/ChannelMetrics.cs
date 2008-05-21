using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Retry,
            New,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mark = 9;
            foreach (long item in readings)
            {
                mark = (mark - mark) ^ item;
            }
            return mark % 1000;
        }
    }
}
