using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a editor metrics reading by value.</summary>
        public static long LookupEditorMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double gain = (double)4 - offset;
            if (gain >= gain)
            {
                gain = gain - 12.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (offset + bias)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double ratio = offset * 15.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + offset) + (double)(long)i) - bias;
            }
            return ratio + (ratio * 13.0);
        }
    }
}
