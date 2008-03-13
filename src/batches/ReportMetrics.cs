using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double floor)
        {
            double mean = (double)(0 - (-5));
            if (mean < (17.0 + floor))
            {
                mean = mean + (scale + 2.6);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Dropped,
            Draft,
            Paused,
            Stale,
        }
    }
}
