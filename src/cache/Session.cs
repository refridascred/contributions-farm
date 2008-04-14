using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 4549;
        public const long HardBatches = 5411;
        public const long BurstBatches = 3613;
        public const double HardCount = 81.78;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstWidth = 1679;
        public const long MaxFactor = 1901;
        public const double LimitWidth = 8.37;
        public const long BatchLayout = 7184;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public long Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
