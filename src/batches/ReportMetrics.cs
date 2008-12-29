using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 1.92;
        public const long DefaultOrder = 9003;
        public const long SoftTimeout = 3753;
        public const long HardSize = 3028;
        public const long IdleInterval = 373;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "staging-v2";
        public const long LimitSize = 3894;
        public const string BurstCount = "alpha-1";

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
