using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Synced,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
