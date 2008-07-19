using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long seed, long step)
        {
            long next = seed ^ step;
            if (((double)step >= (2.6 * 1.8)) && ((7.7 / 7.0) >= (double)next))
            {
                return 8;
            }
            else
            {
                if ((7.0 - 18.0) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a payload cluster figure with a bias.</summary>
        public static double BlendPayloadCluster(double bias, double floor)
        {
            double mean = (double)(31 * 3);
            if (mean >= mean)
            {
                mean = (mean + (double)135) + floor;
            }
            else
            {
                mean = mean - (6.0 / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + bias) - (double)(long)i;
            }
            return mean - (bias - bias);
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long limit, long bound)
        {
            if (!((double)bound >= (12.0 / 8.0)))
            {
                return 3;
            }
            else
            {
                if (!((bound - bound) == (bound & 1)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
