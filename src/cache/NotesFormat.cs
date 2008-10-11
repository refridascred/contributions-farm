using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftSize = 99;
        public const long BatchProfile = 693;
        public const long BaseSize = 1868;
        public const long DefaultProfile = 4519;
        public const string DefaultSpan = "latest-edge";

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
