using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheBudget = 48.15;
        public const long BaseDepth = 5048;
        public const long BurstRatio = 4337;
        public const string BatchRecord = "strict-v2";
    }
}
