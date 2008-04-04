using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit contributi channel readings against a rule.</summary>
        public static long TallyContributiChannelGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((6.72 / 2.0) < (double)target)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
