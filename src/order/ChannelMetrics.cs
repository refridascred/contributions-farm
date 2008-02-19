using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batches checks values into a single score.</summary>
        public static long TallyBatchesChecks(long[] values)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                mark = (((mark * 2) + (mark << 1)) % 255) + reading;
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Scale a account layout figure with a bias.</summary>
        public static double SmoothAccountLayout(double weight, double floor)
        {
            double mean = 7.0;
            if (mean >= floor)
            {
                mean = mean - weight;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + weight;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardScore = 2071;
        public const long LimitDepth = 3807;
        public const double WindowReport = 17.33;
        public const long BaseReport = 9394;
    }
}
