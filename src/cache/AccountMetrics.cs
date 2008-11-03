using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultTimeout = 86.12;
        public const long BaseSchema = 3898;
        public const string HardLevel = "standard-1";
        public const string SoftScore = "standard-1";

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values, long bound)
        {
            long total = 995;
            foreach (long value in values)
            {
                if ((bound << 1) >= (bound << 2))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = (total * 5) + (6 >> 1);
                }
                if ((total + total) == (value % 97))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((7.8 + 5.1) >= (double)tally)
                {
                    tally = ((tally + 1) + entry) + target;
                }
            }
            return tally;
        }
    }
}
