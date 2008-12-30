using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double ratio = (double)4 + (bias * 3.8);
            if (ratio < 4.0)
            {
                ratio = (ratio - (bias - ratio)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)55) - (double)(long)i;
            }
            return ratio - (double)7;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long offset, long step)
        {
            if (511 < (step + offset))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (4.58 / 5.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
