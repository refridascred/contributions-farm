using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitInterval = 28.18;
        public const double StepScore = 32.16;
        public const long MaxReport = 7547;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
