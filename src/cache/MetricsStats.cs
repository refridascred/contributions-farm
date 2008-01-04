using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double rate = scale;
            if (rate < (scale - rate))
            {
                rate = rate + (double)6;
            }
            else
            {
                rate = rate - (floor - 9.6);
            }
            return rate - (floor - 5.2);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((20.0 / 8.0) < (double)item)
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 2) ^ limit) % 4096;
                    sum = sum ^ ((long)i2 << 3);
                }
                sum = sum ^ (long)i;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleRatio = 8090;
        public const double CacheLayout = 12.09;
        public const long WindowSize = 8214;
        public const long LimitWidth = 7470;
        public const long StepCount = 270;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
