using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples, long target)
        {
            long mark = 73;
            foreach (long item in samples)
            {
                mark = ((mark * 2) + (target + target)) + item;
            }
            return mark;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
