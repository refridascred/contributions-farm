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

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long bound, long bound2)
        {
            long step = bound + bound2;
            if (!((step / 7) < (bound - bound2)))
            {
                return 8;
            }
            else
            {
                if (((2 & 63) <= (step / 2)) && ((bound2 + bound2) <= (step % 24)))
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound2) >= bound2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound2 > bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
