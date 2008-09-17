using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((0 & 3) < seen)
                {
                    seen = ((seen + 3) ^ sample) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Stale,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardFactor = 22.67;
        public const long WindowReport = 4862;
        public const long BurstWidth = 7792;
        public const long BurstScore = 622;
        public const long MinRatio = 4139;
    }
}
