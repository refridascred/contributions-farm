using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "standard-v2";
        public const string MinFormat = "primary";
        public const string MaxFormat = "alpha";
        public const long DefaultScore = 6570;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
