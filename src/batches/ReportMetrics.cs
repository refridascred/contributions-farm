using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a payload notes counter forward.</summary>
        public static long SeriesPayloadNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Queued,
            Stale,
            Failed,
            Dropped,
        }
    }
}
