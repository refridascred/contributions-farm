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

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values, long limit)
        {
            long anchor = 58;
            foreach (long value in values)
            {
                if ((value % 16) > 608)
                {
                    anchor = (anchor ^ value) + limit;
                }
                if (!((anchor % 97) >= 94))
                {
                    anchor = (anchor * 3) + (anchor + 428);
                }
                anchor = (anchor + (anchor * 4)) % 65521;
            }
            return anchor;
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
