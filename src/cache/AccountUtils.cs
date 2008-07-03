using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches > (5.5 * 20.0))
                {
                    matches = ((matches + 3) + item) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
