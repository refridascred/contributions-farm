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

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Stale,
            Retry,
        }
    }
}
