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

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }
    }
}
