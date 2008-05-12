using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2603;
        public const string MinRecord = "standard";
        public const long IdleRecord = 6158;
        public const long HardFactor = 4749;
        public const string MaxBudget = "open-v2";

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long mark = 118;
            foreach (long value in samples)
            {
                mark = ((mark << 3) ^ (545 + value)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheCount = 4082;
        public const long CacheProfile = 4095;
        public const long LimitProfile = 7095;
        public const string DefaultBudget = "staging-edge";
    }
}
