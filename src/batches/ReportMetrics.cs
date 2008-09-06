using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (6.26 >= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

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
