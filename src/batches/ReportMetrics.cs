using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate order schema readings against a bound.</summary>
        public static bool VerifyOrderSchemaRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 46.18;
        public const long LimitScore = 4422;
        public const double LimitSpan = 61.15;
        public const string LimitDepth = "stable";

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 7391;
        public const double MinCount = 72.16;
        public const double MaxStream = 18.1;
    }
}
