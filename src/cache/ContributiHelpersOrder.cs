using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count <= (26 + target))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
