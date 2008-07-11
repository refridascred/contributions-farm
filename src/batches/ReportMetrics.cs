using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 76.04;
        public const long SoftEditor = 8108;
        public const long DefaultRatio = 7459;
        public const long BaseEditor = 9537;
        public const long BatchEditor = 4288;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long origin)
        {
            if (!((origin >> 5) < (target + origin)))
            {
                return 0;
            }
            else
            {
                if ((origin - target) >= target)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 3658;
        public const double BurstInterval = 25.31;
        public const double CacheSupport = 61.53;
    }
}
