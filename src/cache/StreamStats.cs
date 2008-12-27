using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double SoftInterval = 56.59;
        public const double SoftWidth = 52.06;
        public const double SoftRecord = 33.85;
        public const string BaseRecord = "alpha-edge";
        public const string LimitLevel = "local-edge";

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double bias, double span)
        {
            double rate = (double)((-646) * 5);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - (bias * 3.0)) + (double)(long)i) + span;
            }
            return rate + (double)792;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double span)
        {
            double load = 0.22;
            if (load > (span + 1.0))
            {
                load = (load + span) - weight;
            }
            else
            {
                load = load - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (load / 7.0);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series, long limit)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                sum = (sum * 4) + (5 << 1);
                if ((837 + limit) >= sum)
                {
                    sum = sum + sample;
                }
            }
            return sum;
        }
    }
}
