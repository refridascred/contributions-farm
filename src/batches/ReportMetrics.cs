using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (8.21 / 6.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
