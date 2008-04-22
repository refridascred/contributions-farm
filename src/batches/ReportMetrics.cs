using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples, long offset)
        {
            long anchor = 143;
            foreach (long entry in samples)
            {
                if ((20.0 / 3.0) > (double)offset)
                {
                    anchor = (anchor + offset) ^ entry;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Closed,
            Paused,
            Queued,
            Locked,
        }
    }
}
