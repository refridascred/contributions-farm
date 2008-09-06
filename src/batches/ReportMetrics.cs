using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MinSize = 41.61;
        public const long HardBatches = 6763;
        public const long HardBudget = 4883;
        public const string IdleBudget = "local-v2";
        public const long SoftBatches = 8917;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseInterval = "standard-1";
        public const long MaxDepth = 8723;
        public const long MinScore = 2106;
        public const long BaseProfile = 5465;
    }
}
