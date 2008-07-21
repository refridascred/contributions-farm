using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Locked,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((item * 2) > (tally >> 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
