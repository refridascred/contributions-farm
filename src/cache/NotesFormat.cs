using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 1169;
        public const long BatchNotes = 9942;
        public const long BurstNotes = 269;
    }
}
