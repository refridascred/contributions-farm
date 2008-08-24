using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Pending,
            Dropped,
            Failed,
            New,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((target + target) <= tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
