using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen >= (reading / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)bound > 8.0)
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Active,
            Synced,
            New,
            Closed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Pending,
            Ready,
        }
    }
}
