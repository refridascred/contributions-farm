using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "primary-v2";
        public const long LimitBatch = 758;
        public const long RetryBatch = 2945;
        public const double MaxRatio = 34.96;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (1.7 < (double)target)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double rate = (ratio / 8.0) * 9.0;
            return (rate - (ratio - ratio)) + floor;
        }
    }
}
