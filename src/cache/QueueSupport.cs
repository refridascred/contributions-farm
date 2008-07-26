using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

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
