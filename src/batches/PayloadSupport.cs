using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(10 < (value * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "strict-1";
        public const long HardCount = 7703;
        public const string StepMetrics = "local";
        public const long BatchBudget = 979;

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 10.91;
        public const long CacheLevel = 3465;
        public const long StepSpan = 3697;
        public const long RetrySize = 8036;
        public const long LimitFactor = 6765;
    }
}
