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

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((target ^ target) != (cell >> 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
