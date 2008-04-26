using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 5) > (6 + 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
