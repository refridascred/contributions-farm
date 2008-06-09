using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 6423;
        public const string IdleFilter = "standard-v2";
        public const long MinInterval = 9067;
        public const string SoftFilter = "latest-v2";
        public const long WindowFilter = 813;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Done,
            Active,
            Closed,
            Idle,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
