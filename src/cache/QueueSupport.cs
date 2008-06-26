using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseCount = 7533;
        public const long MaxSpan = 8872;
        public const string IdleTimeout = "legacy-v2";

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
