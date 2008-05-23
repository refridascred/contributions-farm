using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSpan = 6263;
        public const long HardWidth = 1200;
        public const string StepMetrics = "alpha-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 6221;
        public const double BatchWidth = 77.18;
        public const string WindowWidth = "cached-1";
        public const long DefaultBatches = 1256;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark * 2) + floor;
                if ((double)mark <= (17.0 - 7.3))
                {
                    mark = ((mark * 5) + (floor * 4)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)(-4))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - (scale + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 6.0) + (double)(long)i;
            }
            return bias2 + (bias * 8.21);
        }
    }
}
