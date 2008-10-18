using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 95.22;
        public const long BurstCache = 5324;
        public const long HardCache = 7056;
        public const long IdleCache = 1484;
        public const long MaxWidth = 3606;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
