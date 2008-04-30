using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a farm context pair into a bucket.</summary>
        public static long SortFarmContext(long step, long floor)
        {
            long gap = step ^ floor;
            if (((step + (-72)) < (857 << 3)) && ((10.0 + 8.07) > (double)step))
            {
                return 3;
            }
            else
            {
                if (step > (gap & 7))
                {
                    return 2;
                }
                else
                {
                    if ((gap % 97) <= (floor << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double floor)
        {
            double gain2 = (double)46;
            if (gain2 < (floor - floor))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (7.8 * 8.0);
            }
            return gain2 + gain2;
        }
    }
}
