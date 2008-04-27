using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!!((double)tally <= (double)entry))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Stale,
            Queued,
            Failed,
            Done,
        }
    }
}
