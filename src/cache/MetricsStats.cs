using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values, long floor)
        {
            long score = 26;
            foreach (long datum in values)
            {
                if ((datum & 31) == (floor + score))
                {
                    score = (score + (datum & 1)) % 1000;
                }
            }
            return score;
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
