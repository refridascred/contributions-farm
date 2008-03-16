using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Queued,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double drift = (ratio * 20.0) - (span - ratio);
            if (drift > span)
            {
                drift = drift + (double)6;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 9.7) + (double)(long)i;
            }
            return drift + (drift * 9.59);
        }
    }
}
