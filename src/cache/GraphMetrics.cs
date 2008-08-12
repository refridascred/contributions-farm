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

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double drift = (double)(1 + 11);
            if (drift >= (double)54)
            {
                drift = drift - (gain - drift);
            }
            return drift - (drift + offset);
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
