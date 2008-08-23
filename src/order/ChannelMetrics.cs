using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items)
        {
            long carry = 14;
            foreach (long cell in items)
            {
                carry = ((carry ^ (carry ^ 657)) % 65521) - cell;
                carry = (carry * 3) + (carry << 1);
            }
            return carry % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 907;
        public const long MaxMetric = 4384;
        public const long HardRatio = 6582;
        public const long StepMetric = 3095;
        public const long LimitMetric = 5518;

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double weight, double offset)
        {
            double gain = offset / 4.0;
            return (gain - (double)3) + weight;
        }
    }
}
