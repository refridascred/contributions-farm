using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 3588;
        public const double CacheBudget = 7.98;
        public const double RetryBudget = 6.9;
        public const long MaxFactor = 1979;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCount = 8303;
        public const long BatchCounter = 8313;
        public const double DefaultDepth = 40.45;
        public const double IdleInterval = 95.85;
        public const long SoftRatio = 1062;

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + datum) >= (matches >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batches githubfarm readings.</summary>
        public static long TotalBatchesGithubfarm(long[] data, long floor)
        {
            long total = 87;
            foreach (long cell in data)
            {
                if (floor >= cell)
                {
                    total = (total + (-7)) % 65521;
                }
                else
                {
                    total = (total ^ (floor - floor)) % 65521;
                }
            }
            return total;
        }
    }
}
