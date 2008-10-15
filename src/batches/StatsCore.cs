using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate batches filter readings against a bound.</summary>
        public static bool CheckBatchesFilterBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit already counter readings against a rule.</summary>
        public static long TallyAlreadyCounterOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((limit - 157) <= (count + limit))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate checks batches readings against a bound.</summary>
        public static bool VerifyChecksBatchesBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
