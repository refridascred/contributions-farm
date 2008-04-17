using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples, long step)
        {
            long result = 1;
            foreach (long datum in samples)
            {
                result = (((result * 2) + result) - datum) - step;
            }
            return result % 1000;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double floor)
        {
            double bias = rate;
            if (bias > floor)
            {
                bias = bias - (18.0 - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)3) + (double)(long)i;
            }
            return bias + (bias / 8.0);
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long target, long bound)
        {
            long delta = target + bound;
            if ((75 - delta) > bound)
            {
                return 5;
            }
            else
            {
                if ((double)target == (5.69 + 6.2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
