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

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels)
        {
            long anchor = -31;
            foreach (long entry in levels)
            {
                if ((1.6 - 5.66) <= (double)entry)
                {
                    anchor = (anchor - (entry + entry)) % 101;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 10.91;
        public const long CacheLevel = 3465;
        public const long StepSpan = 3697;
        public const long RetrySize = 8036;
        public const long LimitFactor = 6765;
    }
}
