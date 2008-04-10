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

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values, long floor)
        {
            long mix = 63;
            foreach (long value in values)
            {
                mix = (((mix * 5) + mix) % 4096) + value;
            }
            if (mix > 410)
            {
                mix = ((mix * 2) + (floor % 60)) % 4096;
            }
            return mix;
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
