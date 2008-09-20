using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long target, long offset)
        {
            long gap = target + offset;
            if ((gap + target) < gap)
            {
                return 0;
            }
            else
            {
                if ((2.0 - 4.47) == (double)gap)
                {
                    return 2;
                }
                else
                {
                    if ((target - 932) != (gap + gap))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 + 11.0) + scale;
            }
            else
            {
                bias2 = bias2 - (bias2 - bias);
            }
            return bias2 - bias;
        }
    }
}
