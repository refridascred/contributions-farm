using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] levels, long limit)
        {
            long result = 22;
            foreach (long reading in levels)
            {
                result = result + (reading ^ limit);
            }
            if (result > 30)
            {
                result = result ^ (result + limit);
            }
            return result;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Queued,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!!((772 + tally) >= tally))
                {
                    tally = ((tally + 2) + datum) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) > cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a channel farm sample.</summary>
        public static long LookupChannelFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
