using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double bias = (double)(0 - 0);
            if (bias > (double)46)
            {
                bias = (bias - bias) - ratio;
            }
            else
            {
                bias = bias - (double)74;
            }
            return bias - span;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Closed,
            Active,
            Synced,
            Failed,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }
    }
}
