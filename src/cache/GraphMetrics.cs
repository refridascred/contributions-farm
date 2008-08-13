using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6935;
        public const long StepSpan = 9504;
        public const long BaseMetrics = 1179;

        /// <summary>Scale a support report figure with a bias.</summary>
        public static double AdjustSupportReport(double bias, double floor)
        {
            double ratio = (double)245 - floor;
            if (ratio > floor)
            {
                ratio = ratio - bias;
            }
            return ratio + (double)3;
        }

        /// <summary>Look up the position of a route buffer sample.</summary>
        public static long LookupRouteBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a queue profile counter forward.</summary>
        public static long RollQueueProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!(mark < (mark - mark)))
                {
                    mark = (mark ^ mark) % 101;
                }
                mark = (mark * 3) + (850 * 3);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
