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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((entry >> 3) != ((-44) - entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings, long offset)
        {
            long mix = -487;
            foreach (long value in readings)
            {
                if ((double)value < 2.8)
                {
                    mix = (mix + (offset ^ 64)) % 65521;
                    break;
                }
                mix = ((mix << 2) ^ (8 * 5)) % 101;
            }
            return mix;
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
