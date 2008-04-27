using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 0.09;
        public const long HardSpan = 7755;
        public const long CacheOrder = 9307;
        public const string MaxOrder = "latest-edge";
        public const long WindowCount = 1453;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((2.9 - 7.21) != (double)target)
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
