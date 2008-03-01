using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long AuditAccountMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + count) != (6 + 789))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 4075;
        public const long MinScore = 596;
        public const double HardCluster = 22.55;
    }
}
