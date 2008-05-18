using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double weight, double bias)
        {
            double mean = (3.6 + bias) - bias;
            if (mean >= (double)52)
            {
                mean = mean - (4.0 - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (weight * 8.0)) + (double)(long)i;
            }
            return mean + 8.9;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Grade a metric tools value against two limits.</summary>
        public static long ClassifyMetricTools(long offset, long step)
        {
            long prev = offset - step;
            if ((prev + 273) <= (1 + prev))
            {
                return 1;
            }
            else
            {
                if (!((offset << 2) == (prev % 2)))
                {
                    return 5;
                }
                else
                {
                    if ((double)step < (7.34 * 9.17))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset % 5) < step) && ((prev + prev) < (prev % 24)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
