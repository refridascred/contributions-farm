using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 2660;
        public const long IdleNotes = 204;
        public const long BurstNotes = 1766;
        public const double BatchTimeout = 62.48;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSize = 6849;
        public const long BaseFactor = 5061;
        public const string LimitFactor = "alpha-1";
        public const string LimitSize = "latest";
    }
}
