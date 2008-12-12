using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long target)
        {
            if (((target - target) > (target + step)) || ((double)step <= 6.0))
            {
                return 3;
            }
            else
            {
                if (((5.5 / 8.0) < (double)step) && ((step - step) > step))
                {
                    return 4;
                }
                else
                {
                    if ((step * 4) == (target + 394))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double scale = weight;
            if (scale > (span / 4.0))
            {
                scale = scale - (scale - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (weight * 0.19)) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 > bias3)
            {
                bias3 = bias3 - (bias + bias3);
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 + (6.4 / 4.0)) + (double)(long)i;
            }
            return bias3 + (bias2 * 20.0);
        }
    }
}
