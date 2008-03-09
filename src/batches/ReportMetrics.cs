using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstLevel = 6027;
        public const long BatchTools = 3986;
        public const double SoftWidth = 66.44;
        public const double MinInterval = 53.65;

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 7543;
        public const long CacheSize = 2884;
        public const long LimitDepth = 4363;
        public const long RetryLevel = 5834;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
