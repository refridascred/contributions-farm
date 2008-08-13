using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (48 > (seen & 31))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 5568;
        public const double BaseFormat = 58.09;
        public const double HardSize = 80.65;
        public const double HardRatio = 79.23;
    }
}
