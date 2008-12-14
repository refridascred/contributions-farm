using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Retry,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
