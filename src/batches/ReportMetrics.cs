using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long seed)
        {
            if ((1 * 4) < (seed >> 5))
            {
                return 0;
            }
            else
            {
                if (!(seed <= (seed - seed)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a counter tools reading.</summary>
        public static double BlendCounterTools(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 < gain)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - floor;
            }
            return gain2 + (double)21;
        }
    }
}
