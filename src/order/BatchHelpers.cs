using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long MeasureCommitsStatsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (bound <= (value + bound))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Draft,
            Retry,
            Done,
        }
    }
}
