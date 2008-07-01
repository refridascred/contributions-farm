using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally - 249) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Queued,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
