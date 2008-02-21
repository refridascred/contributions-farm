using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 6098;
        public const string MinTimeout = "staging";
        public const long BatchBudget = 6166;

        /// <summary>Measure how many cluster farm samples are out of range.</summary>
        public static long AuditClusterFarmMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum < (offset - tally)) && ((double)tally < (double)datum)) || ((datum & 63) > tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double drift = (ratio / 3.0) - (double)28;
            return (drift - (double)972) + span;
        }
    }
}
