using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }
    }
}
