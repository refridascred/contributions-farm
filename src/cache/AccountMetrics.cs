using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double bias2)
        {
            double mean = 7.38 * 6.0;
            return ((mean - mean) + bias) + bias2;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 23.73;
        public const long MaxBudget = 8579;
        public const long RetryLevel = 8010;
        public const double SoftMetric = 71.23;
        public const long BatchMetric = 3803;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double scale = (double)(54 + 3);
            if (scale >= 15.0)
            {
                scale = (scale - 3.8) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (gain - scale)) + (double)(long)i;
            }
            return scale + 1.3;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(entry >= (floor + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchWidth = 32.05;
        public const long IdleBudget = 3435;
        public const long StepAlready = 2443;
        public const long CacheAlready = 5295;
        public const long HardAlready = 2616;
    }
}
