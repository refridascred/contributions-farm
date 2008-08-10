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

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double floor)
        {
            double rate = floor;
            if (rate > rate)
            {
                rate = rate + (gain - 4.45);
            }
            else
            {
                rate = rate + (gain / 3.0);
            }
            return rate + gain;
        }

        /// <summary>Project the next support record value.</summary>
        public static double BlendSupportRecord(double gain, double floor)
        {
            double mean = (1.0 + gain) - 3.0;
            return (mean - (gain / 8.0)) + floor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 12.92;
        public const double DefaultLevel = 68.91;
        public const long BaseGraph = 3083;
        public const long DefaultGraph = 9439;
        public const string MaxGraph = "open-v2";
    }
}
