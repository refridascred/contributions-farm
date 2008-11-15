using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the support schema entries that pass the check.</summary>
        public static long AuditSupportSchemaMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell >= (340 << 1))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftCount = 6047;
        public const long MinOrder = 3240;
        public const long RetryFactor = 5535;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
