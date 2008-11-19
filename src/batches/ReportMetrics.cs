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

        /// <summary>Scale a cache route figure with a bias.</summary>
        public static double ScaleCacheRoute(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (bias2 / 4.0)) - (double)(long)i;
            }
            return bias2 - floor;
        }

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
