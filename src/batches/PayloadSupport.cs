using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the checks report entries that pass the check.</summary>
        public static long AuditChecksReportOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!!((5 + tally) < item))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
