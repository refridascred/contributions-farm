using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 8170;
        public const long RetryProfile = 5936;
        public const double WindowSpan = 4.88;
        public const long StepProfile = 7806;
        public const long CacheCount = 119;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen > (6.87 + 20.0))
                {
                    seen = ((seen + 3) ^ cell) + step;
                }
            }
            return seen;
        }

        /// <summary>Check that every context report entry stays within the limit.</summary>
        public static bool CheckContextReportLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
