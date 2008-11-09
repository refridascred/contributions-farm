using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Stale,
            Active,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseFactor = 491;
        public const double MaxSpan = 20.71;
        public const string MinWidth = "cached-1";
        public const double BaseTimeout = 58.17;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 - offset) + weight;
        }
    }
}
