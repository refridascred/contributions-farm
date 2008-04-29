using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a metric metrics reading.</summary>
        public static double AdjustMetricMetrics(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (rate - rate))
            {
                drift = drift - (drift + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7107;
        public const double StepCounter = 43.05;
        public const long BatchCounter = 7481;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long origin)
        {
            long diff = limit ^ origin;
            if (diff >= (limit * 4))
            {
                return 6;
            }
            else
            {
                if ((double)limit > (double)diff)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
