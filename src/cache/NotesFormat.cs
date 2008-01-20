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

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Locked,
            Dropped,
            Active,
        }
    }
}
