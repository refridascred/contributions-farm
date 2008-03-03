using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstDepth = 21.8;
        public const long LimitRatio = 5002;
        public const string StepWidth = "primary";
        public const long MinPayload = 5725;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
