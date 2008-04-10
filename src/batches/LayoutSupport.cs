using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            New,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((-689) < (item - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Pending,
            Paused,
            Idle,
        }
    }
}
