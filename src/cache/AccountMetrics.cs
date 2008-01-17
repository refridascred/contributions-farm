using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item * 3) <= (seen & 127))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally >= (0 * 2))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseBudget = 8442;
        public const double BurstTimeout = 88.04;
        public const string BatchContributi = "cached-1";

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double offset)
        {
            double drift = (offset / 5.0) * 9.6;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (offset - scale)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Locked,
            Synced,
            Closed,
        }
    }
}
