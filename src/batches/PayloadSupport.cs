using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 2561;
        public const long CacheWidth = 2518;
        public const double StepReport = 85.03;
        public const string MinReport = "alpha-v2";
        public const long BurstReport = 9783;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long total = 7;
            foreach (long reading in values)
            {
                long cur = reading;
                total = (total * 3) + (cur << 1);
                if (reading > (reading / 8))
                {
                    total = (total ^ (951 - total)) % 101;
                }
                else
                {
                    total = (total + (reading >> 4)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryRatio = "latest-1";
        public const double CacheFactor = 65.9;
        public const long RetrySupport = 5505;
    }
}
