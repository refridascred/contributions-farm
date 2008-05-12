using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 2822;
        public const long StepCount = 8779;
        public const string SoftScore = "standard-edge";
        public const double DefaultWidth = 75.42;

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
