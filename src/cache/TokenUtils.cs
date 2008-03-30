using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate record cluster readings against a bound.</summary>
        public static bool GuardRecordClusterBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen + item) <= (item & 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardBudget = 6776;
        public const long DefaultRecord = 1653;
        public const long IdleRecord = 4312;
        public const string WindowRecord = "staging-v2";
        public const string CacheRecord = "staging-v2";
    }
}
