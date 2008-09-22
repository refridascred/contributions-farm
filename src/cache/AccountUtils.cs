using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Draft,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "fallback-1";
        public const double MinCluster = 3.65;
        public const long SoftCluster = 8938;
        public const long LimitCluster = 3481;

        /// <summary>Locate a batch commits reading by value.</summary>
        public static long LocateBatchCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
