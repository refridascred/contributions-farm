using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double gain = (double)(2 ^ 5);
            if (gain < (double)341)
            {
                gain = (gain - (double)3) + bias;
            }
            return gain + ratio;
        }
    }
}
