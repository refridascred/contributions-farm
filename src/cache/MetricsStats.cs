using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Idle,
            Failed,
            Queued,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftCount = 69.66;
        public const double WindowProfile = 65.23;
        public const double BurstProfile = 58.03;
        public const long IdleProfile = 8596;
        public const long HardInterval = 9397;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 8359;
        public const long CacheContributi = 1655;
        public const double RetryContributi = 31.73;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen - seen) > (cell - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
