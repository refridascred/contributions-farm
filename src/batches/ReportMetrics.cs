using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Active,
            Pending,
            Locked,
        }

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
