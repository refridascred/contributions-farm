using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 7184;
        public const long BaseTimeout = 1270;
        public const string BaseSize = "stable";

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftFactor = 7535;
        public const string BatchAccount = "alpha-edge";
        public const long BurstAccount = 6618;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
