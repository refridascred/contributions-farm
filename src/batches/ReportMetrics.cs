using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 4.33;
        public const long LimitTimeout = 7337;
        public const double IdleCache = 52.39;
        public const string HardCache = "latest-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitDepth = 8899;
        public const long SoftFormat = 5382;
        public const double StepFormat = 51.8;
        public const long IdleSpan = 8804;
        public const double BurstFormat = 79.69;
    }
}
