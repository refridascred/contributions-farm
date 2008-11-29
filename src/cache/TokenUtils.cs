using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!!((cell + hits) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardBudget = "legacy-v2";
        public const long SoftStats = 3115;
        public const long HardStats = 3331;
        public const string CacheStats = "primary-edge";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
