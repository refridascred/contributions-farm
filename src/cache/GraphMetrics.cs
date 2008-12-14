using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a profile graph reading.</summary>
        public static double BlendProfileGraph(double scale, double offset)
        {
            double gain = scale;
            if (gain > gain)
            {
                gain = gain + (double)6;
            }
            else
            {
                gain = gain + offset;
            }
            return gain + (double)6;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long limit, long bound)
        {
            long step = limit - bound;
            if ((bound ^ limit) > (bound & 31))
            {
                return 7;
            }
            else
            {
                if ((323 < limit) && ((5.0 + 9.8) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((6 << 2) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step >> 2) <= (947 % 60))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double bias = 1.89;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + gain) + (double)(long)i) - offset;
            }
            return bias - (double)9;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
