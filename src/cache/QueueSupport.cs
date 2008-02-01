using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 74.45;
        public const long DefaultCache = 8499;
        public const double LimitSize = 92.18;
    }
}
