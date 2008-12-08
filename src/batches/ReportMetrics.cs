using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double drift = (double)(413 + 64);
            if (drift > bias)
            {
                drift = (drift - (drift * 8.05)) + gain;
            }
            return drift - (bias / 7.0);
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long limit)
        {
            if (!((double)limit != (6.83 + 20.0)))
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (3.3 - 6.95))
                {
                    return 5;
                }
                else
                {
                    if (((target ^ limit) > (target * 2)) && ((target - limit) > (target & 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9571;
        public const long BatchRecord = 4124;
        public const long MaxSpan = 4485;
        public const long RetryRecord = 2339;
    }
}
