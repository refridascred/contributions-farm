using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 9921;
        public const double BaseStats = 68.79;
        public const long WindowStats = 7074;
        public const long MaxInterval = 619;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
