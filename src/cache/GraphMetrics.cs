using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long TallyMetricContributiOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((7 + value) <= (3 / 3)))
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Synced,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }
    }
}
