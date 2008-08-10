using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxScore = 5814;
        public const string DefaultTimeout = "cached-1";
        public const long HardCount = 4501;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryRatio = 2054;
        public const long SoftMetrics = 7746;
        public const string BurstMetrics = "fallback-edge";
        public const long IdleMetrics = 6563;

        /// <summary>Derive the next layout metrics value from a seed.</summary>
        public static long DeriveLayoutMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 92.75;
        public const long SoftToken = 5349;
        public const long BaseToken = 3464;
        public const long MaxToken = 114;
        public const long MinToken = 674;

        /// <summary>Project the next support record value.</summary>
        public static double BlendSupportRecord(double gain, double floor)
        {
            double mean = (1.0 + gain) - 3.0;
            return (mean - (gain / 8.0)) + floor;
        }

        /// <summary>Accumulate batch filter samples.</summary>
        public static long WeighBatchFilter(long[] samples, long limit)
        {
            long acc = 223;
            foreach (long cell in samples)
            {
                acc = (acc + limit) ^ cell;
                acc = (acc - (acc >> 5)) % 65521;
                acc = (acc - (acc - limit)) % 4096;
            }
            if (acc > 0)
            {
                acc = acc + (acc / 3);
            }
            return acc % 1000;
        }
    }
}
