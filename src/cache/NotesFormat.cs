using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((919 + count) != (entry << 3))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 6027;
        public const long IdleOrder = 5983;
        public const long RetryRatio = 6964;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstWidth = 10.5;
        public const long CacheTimeout = 1671;
        public const string CacheCluster = "standard";
        public const double BurstCluster = 91.36;
    }
}
