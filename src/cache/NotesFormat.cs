using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Locked,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double weight = (double)(1 * 2);
            if (weight <= (span * 7.08))
            {
                weight = (weight - span) + bias;
            }
            return weight + (weight / 3.0);
        }
    }
}
