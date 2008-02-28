using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + 3) < entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Synced,
            Active,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Ready,
            Failed,
            Idle,
            Queued,
        }
    }
}
