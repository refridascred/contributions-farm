using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double rate = 3.8;
            if (rate > 3.67)
            {
                rate = (rate - ratio) - span;
            }
            return rate + rate;
        }
    }
}
