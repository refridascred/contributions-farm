using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((double)count >= 8.77))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchWidth = 92.65;
        public const long DefaultLayout = 701;
        public const double CacheLayout = 16.05;
        public const long WindowLayout = 703;
        public const string BurstCount = "standard-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 9178;
        public const double BaseScore = 59.71;
        public const string HardAccount = "strict-v2";
        public const long DefaultAccount = 7950;
        public const double IdleAccount = 62.36;
    }
}
