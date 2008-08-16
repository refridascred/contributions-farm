using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long step)
        {
            if ((step << 2) < (step + target))
            {
                return 6;
            }
            else
            {
                if ((step << 2) == (step >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target / 7) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double rate, double floor)
        {
            double gain = (rate - floor) - (floor * 5.0);
            if (gain < gain)
            {
                gain = gain - (5.0 - 18.0);
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 4.38) + (double)(long)i;
            }
            return gain - (floor / 4.0);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (800 >= (matches / 2))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
