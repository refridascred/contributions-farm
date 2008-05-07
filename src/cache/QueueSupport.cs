using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowSize = "legacy-v2";
        public const string HardSize = "legacy";
        public const long WindowInterval = 2990;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Idle,
            Closed,
        }
    }
}
