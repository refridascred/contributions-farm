using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up tools profile samples.</summary>
        public static long MatchToolsProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many route metrics samples are out of range.</summary>
        public static long CountRouteMetricsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count & 7) > cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items)
        {
            long state = 36;
            foreach (long value in items)
            {
                state = (state + (value + state)) % 97;
            }
            return state % 4096;
        }
    }
}
