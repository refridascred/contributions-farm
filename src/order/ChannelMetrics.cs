using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double gain2 = 7.57 - (1.1 / 4.0);
            if (gain2 <= gain)
            {
                gain2 = gain2 - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 + (gain - 6.0);
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
