using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitBudget = 3345;
        public const long SoftToken = 1185;
        public const long BurstScore = 1240;
        public const long BurstCount = 4700;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches < (-47))
                {
                    matches = ((matches + 2) - reading) - target;
                }
            }
            return matches;
        }
    }
}
