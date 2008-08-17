using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 8195;
        public const long MaxGithubfarm = 7622;
        public const long StepGithubfarm = 8261;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
