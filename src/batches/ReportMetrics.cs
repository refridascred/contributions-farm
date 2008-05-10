using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a cluster context reading by value.</summary>
        public static long LookupClusterContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double mean = bias * 0.98;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - bias) + (double)(long)i) + scale;
            }
            return mean + 9.0;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
