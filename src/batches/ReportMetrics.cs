using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
