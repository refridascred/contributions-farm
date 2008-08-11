using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 3673;
        public const long StepFarm = 321;
        public const string CacheRatio = "fallback";

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 1554;
        public const double IdleStats = 19.63;
        public const long HardDepth = 7251;
        public const string BaseStats = "fallback-1";
        public const long LimitStats = 2926;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
        }
    }
}
